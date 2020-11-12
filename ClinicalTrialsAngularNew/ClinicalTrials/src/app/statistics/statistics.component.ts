import { Component, OnInit, AfterViewInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import MarkerClusterer from '@googlemaps/markerclustererplus';
import { StatisticsService } from '../services/statistics-service';
import d3 = require('d3');
import { SearchDTO } from '../DTO/searchDTO';
import { GeolocationService } from '../services/geolocation-service.service';
import { Observable } from 'rxjs';
import { LocationDTO } from '../DTO/locationDTO';


@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.css']
})
export class StatisticsComponent implements OnInit {

  searchForm = new FormGroup({
    Condition: new FormControl(''),
    Country: new FormControl(''),
    Sponsor: new FormControl('')
  });

  title = 'My first AGM project';
  lat = 51.678418;
  lng = 7.809007;
  

  private trialsByYearData = [];
  private studyTypeData = [];
  private statusData = [];
  private phaseListData = [];
  private locationData = [];
  private sponsorData = [];
  private durationData = [];


  private svg;
  private margin = 50;
  private width = 550 - (this.margin * 2);
  private height = 400 - (this.margin * 2);
  
  searchDTO: SearchDTO = new SearchDTO();

  constructor(private _searchService: StatisticsService, private _locationService: GeolocationService) { }

  maxWidth: number;

  locationDTO: LocationDTO;

  ngOnInit(): void {
    this.locationDTO = new LocationDTO();
  }

  ngAfterViewInit(): void {
    // Load google maps script after view init
    const DSLScript = document.createElement('script');
    DSLScript.src = 'https://maps.googleapis.com/maps/api/js?key=AIzaSyBjC5xykhdXPNmyv3ffc7JXWzzrHteQlrA'; // replace by your API key
    DSLScript.type = 'text/javascript';
    document.body.appendChild(DSLScript);
    document.body.removeChild(DSLScript);
  }


  onSubmit() {
    
    if (this.svg != undefined) {
      d3.select("figure#trialsByYear").select("svg").remove();
      d3.select("figure#studyType").select("svg").remove();
      d3.select("figure#status").select("svg").remove();
      d3.select("figure#phaseList").select("svg").remove();
      d3.select("figure#location").select("svg").remove();
      d3.select("figure#sponsor").select("svg").remove();
      d3.select("figure#duration").select("svg").remove();
    }

    this.searchDTO = this.searchForm.value;

    this._searchService.searchStatistics(this.searchDTO).subscribe(response => {
      this._searchService.getChart('/sponsor').subscribe(data => {
        this.createSponsorChart(data);
      });
      //will convert response from any[] to locationDTO
      this._searchService.getChart('/location').subscribe(data => {
        for(let loc of data){
          if(loc.Coordinates == null)
            continue;
          this.locationDTO.locations.push({ lat: Number(loc.Coordinates.split(",")[0]), lng: Number(loc.Coordinates.split(",")[1]) });
          this.locationDTO.labels.push(loc.NUM);
        }
        this.createGoogleMap();
      });
      this._searchService.getChart('/country').subscribe(data => {
        this.createLocationChart(data);
      });

      this._searchService.getChart('/trialsByYear').subscribe(data => {
        if (data != null) {
          this.trialsByYearData = data;
          //this.createSvg("trialsByYear");
          this.createLineChart(this.trialsByYearData);
        }
      });
      this._searchService.getChart('/studyType').subscribe(data => {
        if (data != null) {
          //this.studyTypeData = data;
          this.createDoughnutChart(data);
        }
      });
      this._searchService.getChart('/status').subscribe(data => {
        if (data != null) {
          //this.statusData = data;
          this.createStatusChart(data);

          this._searchService.getChart('/phaseList').subscribe(data => {
            if (data != null) {
              this.phaseListData = data;
              this.createBarChart("phaseList");
            }
          });
        }
      });
      this._searchService.getChart('/sponsor').subscribe(data => {
        if (data != null) {
          this.sponsorData = data;
        }
      });
      this._searchService.getChart('/duration').subscribe(data => {
        if (data != null) {
          this.durationData = data;
        }
      });
    });

  }

  private createSponsorChart(data: any[]){
    
    /*var newData = [];
    if(data.length >= 15){
      data.sort((a, b) => (a.NUM > b.NUM) ? -1 : 1)
    
      var sum = 0;
      data.forEach(function (value, i) {
        if(i > 15){
          sum += value.NUM;
        } else {
          newData.push(value);
        }
      });
      newData.push({LeadSponsorName:"Other", NUM: sum})
    }*/

    const svg = d3.select("figure#sponsor").append("svg")
      .attr("width", this.width + (this.margin * 2))
      .attr("height", this.height + (this.margin * 2))
      .append("g")
      .attr("transform", "translate(" + this.margin * 6 + "," + this.margin * 4 + ")");

    var radius = Math.min(this.width + (this.margin * 2), this.height + (this.margin * 2)) / 2 - this.margin

    // set the color scale
    var color = d3.scaleOrdinal()
      .domain(data.map(d => d.StudyType))
      .range(["#04BF9D", "#3E372A", "#2CB199", "#7D735F", "#34a892", "#20b196", "#493832", "#20d5b4", "#765b51", "#e8e0de", "#304c29", "#17deb9"]);
    //.range(d3.schemeDark2);

    var numData = data.map(d => d.NUM);
    // Compute the position of each group on the pie:
    var pie = d3.pie()
      .sort(null) // Do not sort group by size
      .value(function (d) { return (d as any).NUM; })
    var data_ready = pie(data)

    // The arc generator
    var arc = d3.arc()
      .innerRadius(0)         // This is the size of the donut hole
      .outerRadius(radius * 0.8)

    // Another arc that won't be drawn. Just for labels positioning
    var outerArc = d3.arc()
      .innerRadius(radius * 0.9)
      .outerRadius(radius * 0.9)

    svg.append("text")
      .attr("x", (this.width/50 - 10))             
      .attr("y", this.margin - 200 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("Sponsors percentage");

    // Define the div for the tooltip
    var div = d3.select("body").append("div")
      .attr("class", "tooltip")
      .style("opacity", 0);

    // Build the pie chart: Basically, each part of the pie is a path that we build using the arc function.
    svg
      .selectAll('allSlices')
      .data(data_ready)
      .enter()
      .append('path')
      .attr('d', arc as any)
      .attr('fill', function (d) { return (color((d.data as any).LeadSponsorName)) as any})
      .attr("stroke", "white")
      .style("stroke-width", "2px")
      .style("opacity", 0.7)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials: " + d.target.__data__.data.NUM + "<br/>" + "Sponsor: " + d.target.__data__.data.LeadSponsorName)
          .style("left", (d.pageX) + "px")
          .style("top", (d.pageY) + "px")
          .style("position", "absolete")
          .style("background", "#1d2b29")
          .style("color", "#ffffff")
          .style("padding", "2px")
          .style("border-radius", "8px")
          .style("font", " 12px")
          .style("text-align", "center");
      })
      .on("mouseout", function (d) {
        d3.select(this)
          .style("cursor", "default");
        div.transition()
          .duration(500)
          .style("opacity", 0);
      });
  }

  private createGoogleMap(){
    const styledMapType = new google.maps.StyledMapType(
      [
        { elementType: "geometry", stylers: [{ color: "#2cb199" }] },
        { elementType: "labels.text.fill", stylers: [{ color: "#523735" }] },
        { elementType: "labels.text.stroke", stylers: [{ color: "#f5f1e6" }] },
        {
          featureType: "administrative",
          elementType: "geometry.stroke",
          stylers: [{ color: "#c9b2a6" }],
        },
        {
          featureType: "administrative.land_parcel",
          elementType: "geometry.stroke",
          stylers: [{ color: "#dcd2be" }],
        },
        {
          featureType: "administrative.land_parcel",
          elementType: "labels.text.fill",
          stylers: [{ color: "#ae9e90" }],
        },
        {
          featureType: "landscape.natural",
          elementType: "geometry",
          stylers: [{ color: "#69c7b5" }],
        },
        {
          featureType: "poi",
          elementType: "geometry",
          stylers: [{ color: "#dfd2ae" }],
        },
        {
          featureType: "poi",
          elementType: "labels.text.fill",
          stylers: [{ color: "#93817c" }],
        },
        {
          featureType: "poi.park",
          elementType: "geometry.fill",
          stylers: [{ color: "#a5b076" }],
        },
        {
          featureType: "poi.park",
          elementType: "labels.text.fill",
          stylers: [{ color: "#447530" }],
        },
        {
          featureType: "road",
          elementType: "geometry",
          stylers: [{ color: "#f5f1e6" }],
        },
        {
          featureType: "road.arterial",
          elementType: "geometry",
          stylers: [{ color: "#fdfcf8" }],
        },
        {
          featureType: "road.highway",
          elementType: "geometry",
          stylers: [{ color: "#f8c967" }],
        },
        {
          featureType: "road.highway",
          elementType: "geometry.stroke",
          stylers: [{ color: "#e9bc62" }],
        },
        {
          featureType: "road.highway.controlled_access",
          elementType: "geometry",
          stylers: [{ color: "#e98d58" }],
        },
        {
          featureType: "road.highway.controlled_access",
          elementType: "geometry.stroke",
          stylers: [{ color: "#db8555" }],
        },
        {
          featureType: "road.local",
          elementType: "labels.text.fill",
          stylers: [{ color: "#806b63" }],
        },
        {
          featureType: "transit.line",
          elementType: "geometry",
          stylers: [{ color: "#dfd2ae" }],
        },
        {
          featureType: "transit.line",
          elementType: "labels.text.fill",
          stylers: [{ color: "#8f7d77" }],
        },
        {
          featureType: "transit.line",
          elementType: "labels.text.stroke",
          stylers: [{ color: "#ebe3cd" }],
        },
        {
          featureType: "transit.station",
          elementType: "geometry",
          stylers: [{ color: "#dfd2ae" }],
        },
        {
          featureType: "water",
          elementType: "geometry.fill",
          stylers: [{ color: "#ffffff" }],
        },
        {
          featureType: "water",
          elementType: "labels.text.fill",
          stylers: [{ color: "#92998d" }],
        },
      ],
      { name: "Styled Map" }
    );

    const map = new google.maps.Map(
      document.getElementById("map") as HTMLElement,
      {
        zoom: 2,
        center: { lat: 20, lng: 0 },
        mapTypeControlOptions: {
          mapTypeIds: ["roadmap", "satellite", "hybrid", "terrain", "styled_map"],
        },
      } 
    );
    
    //Associate the styled map with the MapTypeId and set it to display.
    map.mapTypes.set("styled_map", styledMapType);
    map.setMapTypeId("styled_map");
    
    // Add some markers to the map.
    // Note: The code uses the JavaScript Array.prototype.map() method to
    // create an array of markers based on a given "locations" array.
    // The map() method here has nothing to do with the Google Maps API.
    const markers = this.locationDTO.locations.map((location, i) => {
      return new google.maps.Marker({
        position: location,
        label: (this.locationDTO.labels[i]).toString()
        //label: this.labels[i % this.labels.length],
      });
    });

    //this.getMarkers().then((markers) => {
    // Add a marker clusterer to manage the markers.
    // @ts-ignore MarkerClusterer defined via script
    new MarkerClusterer(map, markers, {
      imagePath:
        "https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m",
      });    
  }

  private createStatusChart(data: any[]) {
    const svg = d3.select("figure#status")
      .append("svg")
      .attr("width", this.width + (this.margin * 2))
      .attr("height", this.height + (this.margin * 2))
      .append("g")
      .attr("transform", "translate(" + this.margin + "," + this.margin + ")");

    // Create the Y-axis band scale
    const x = d3.scaleLinear()
      .domain([0, d3.max(data, function (d) { return d.NUM + 10; })])
      .range([0, this.width]);

    //Define the chart colors
    let colors = d3.scaleOrdinal()
      .domain(data.map(d => d.OverallStatus))
      .range(["#34a892", "#20b196", "#1ec8a9", "#20d5b4", "#17deb9"]);


    // Define max label for translating the chart
    var maxLabel = d3.max(data, function (d) { return d.OverallStatus; }), maxWidth;

    svg.append("text").text(maxLabel)
      .each(function () { maxWidth = this.getBBox().width; })
      .remove();

    this.maxWidth = maxWidth;

    // Draw the X-axis on the DOM
    svg.append("g")
      //.attr("transform", "translate(0," + this.height + ")")
      .attr("transform", "translate(" + Math.max(this.margin, maxWidth) + "," + this.height + ")")
      .call(d3.axisBottom(x))
      .selectAll("text")
      .attr("transform", "translate(-10,0)rotate(-20)")
      .style("text-anchor", "end");

    const y = d3.scaleBand()
      .range([0, this.height])
      .domain(data.map(d => d.OverallStatus));

    //svg.attr("transform", "translate(" + Math.max(this.margin, maxWidth) + "," + this.margin + ")");

    // Draw the Y-axis on the DOM
    svg.append("g")
      .attr("transform", "translate(" + Math.max(this.margin, maxWidth) + ")")
      .call(d3.axisLeft(y))
      .selectAll("text")
      //.attr("transform", "translate(-10,0))")
      .style("text-anchor", "end");

    // Define the div for the tooltip
    var div = d3.select("body").append("div")
      .attr("class", "tooltip")
      .style("opacity", 0);

    var bars = svg.selectAll(".bar")
      .data(data)
      .enter()
      .append("g")

    let barsMargin = Math.max(this.margin, maxWidth) + 1;

    //append rects
    bars.append("rect")
      .attr("fill", (d, i) => colors(i.toString()) as any)
      .attr("y", function (d) {
        return y(d.OverallStatus);
      })
      .attr("transform", "translate(" + barsMargin + ", 0)")
      .attr("x", d => x(d.NUM))
      .attr("height", y.bandwidth())
      .attr("class", "bar")
      .attr("width", function (d) {
        return 0;
      })   
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials: " + d.target.__data__.NUM + "<br/>" + "Status: " + d.target.__data__.OverallStatus)
          .style("left", (d.screenX) + "px")
          .style("top", (d.screenY - 28) + "px")
          .style("position", "absolete")
          .style("background", "#1d2b29")
          .style("color", "#ffffff")          
          .style("padding", "2px")
          .style("border-radius", "8px")
          .style("font", " 12px")
          .style("text-align", "center");
      })
      .on("mouseout", function (d) {
        d3.select(this)
          .style("cursor", "default");
        div.transition()
          .duration(500)
          .style("opacity", 0);
      });

    // Animation
    svg.selectAll("rect")
      .transition()
      .duration(800)
      .attr("x", 0)
      .attr("width", (d) => x((d as any).NUM))
      .delay(function (d, i) { return (i * 100) })
  }

  private createLocationChart(data: any[]) {
    const svg = d3.select("figure#location")
      .append("svg")
      .attr("width", this.width + (this.margin * 2))
      .attr("height", this.height + (this.margin * 2))
      .append("g")
      .attr("transform", "translate(" + this.margin + "," + this.margin + ")");

    // Create the Y-axis band scale
    const x = d3.scaleLinear()
      .domain([0, d3.max(data, function (d) { return d.NUM + 10; })])
      .range([0, this.width]);

    //Define the chart colors
    let colors = d3.scaleOrdinal()
      .domain(data.map(d => d.OverallStatus))
      .range(["#34a892", "#20b196", "#493832", "#20d5b4", "#765b51", "#e8e0de", "#304c29", "#17deb9"]);


    // Define max label for translating the chart
    var maxLabel = d3.max(data, function (d) { return d.LocationCountry; }), maxWidth;

    svg.append("text").text(maxLabel)
      .each(function () { maxWidth = this.getBBox().width; })
      .remove();

    this.maxWidth = maxWidth;

    // Draw the X-axis on the DOM
    svg.append("g")
      //.attr("transform", "translate(0," + this.height + ")")
      .attr("transform", "translate(" + Math.max(this.margin, maxWidth) + "," + this.height + ")")
      .call(d3.axisBottom(x))
      .selectAll("text")
      .attr("transform", "translate(-10,0)rotate(-20)")
      .style("text-anchor", "end");

    const y = d3.scaleBand()
      .range([0, this.height])
      .domain(data.map(d => d.LocationCountry));

    //svg.attr("transform", "translate(" + Math.max(this.margin, maxWidth) + "," + this.margin + ")");

    // Draw the Y-axis on the DOM
    svg.append("g")
      .attr("transform", "translate(" + Math.max(this.margin, maxWidth) + ")")
      .call(d3.axisLeft(y))
      .selectAll("text")
      //.attr("transform", "translate(-10,0))")
      .style("text-anchor", "end");

    // Define the div for the tooltip
    var div = d3.select("body").append("div")
      .attr("class", "tooltip")
      .style("opacity", 0);

    var bars = svg.selectAll(".bar")
      .data(data)
      .enter()
      .append("g")

    let barsMargin = Math.max(this.margin, maxWidth) + 1;

    //append rects
    bars.append("rect")
      .attr("fill", (d, i) => colors(i.toString()) as any)
      .attr("y", function (d) {
        return y(d.LocationCountry);
      })
      .attr("transform", "translate(" + barsMargin + ", 0)")
      .attr("x", d => x(d.NUM))
      .attr("height", y.bandwidth())
      .attr("class", "bar")
      .attr("width", function (d) {
        return 0;
      })   
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials: " + d.target.__data__.NUM + "<br/>" + "LocationCountry: " + d.target.__data__.LocationCountry)
          .style("left", (d.pageX) + "px")
          .style("top", (d.pageY) + "px")
          .style("position", "absolete")
          .style("background", "#1d2b29")
          .style("color", "#ffffff")
          .style("padding", "2px")
          .style("border-radius", "8px")
          .style("font", " 12px")
          .style("text-align", "center");
      })
      .on("mouseout", function (d) {
        d3.select(this)
          .style("cursor", "default");
        div.transition()
          .duration(500)
          .style("opacity", 0);
      });

    // Animation
    svg.selectAll("rect")
      .transition()
      .duration(800)
      .attr("x", 0)
      .attr("width", (d) => x((d as any).NUM))
      .delay(function (d, i) { return (i * 100) })
  }

  private createBarChart(type: string): void {
    var newMargin = this.margin + this.maxWidth + 70;

    this.svg = d3.select("figure#" + type)
      .append("svg")
      .attr("width", this.width + (this.margin * 2))
      .attr("height", this.height + (this.margin * 2))
      .append("g")
      .attr("transform", "translate(" + newMargin + "," + this.margin + ")");

    switch (type) {
      case "phaseList":
        this.drawBars(this.phaseListData);
        break;
    }

  }

  private drawBars(data: any[]): void {
    data.forEach(element => {
      element.Phase = element.Phase.replace('[\"', '');
      element.Phase = element.Phase.replace('\"]', '');
      element.Phase = element.Phase.replace('\",\"', ', ');
    });

    var newMargin = this.margin + this.maxWidth;

    // Create the X-axis band scale
    const x = d3.scaleBand()
      .range([0, this.width - newMargin])
      .domain(data.map(d => d.Phase))
      .padding(0.4);

    let colors = d3.scaleOrdinal()
      .domain(data.map(d => d.NUM.toString()))
      .range(["#34a892", "#20b196", "#1ec8a9", "#20d5b4", "#17deb9"]);


    // Draw the X-axis on the DOM
    this.svg.append("g")
      .attr("transform", "translate(0," + this.height + ")")
      .call(d3.axisBottom(x))
      .selectAll("text")
      .attr("transform", "translate(-10,0)rotate(-20)")
      .style("text-anchor", "end");
    // Scalable Y-axis
    var max = Math.max.apply(Math, data.map(function (o) { return o.NUM; }))
    // Create the Y-axis band scale
    const y = d3.scaleLinear()
      .domain([0, d3.max(data, function (d) { return d.NUM + 10; })])
      .range([this.height, 0]);

    // Draw the Y-axis on the DOM
    this.svg.append("g")
      .call(d3.axisLeft(y));

    // Define the div for the tooltip
    var div = d3.select("body").append("div")
      .attr("class", "tooltip")
      .style("opacity", 0);

    // Create and fill the bars
    this.svg.selectAll("bars")
      .data(data)
      .enter()
      .append("rect")
      .attr("x", d => x(d.Phase))
      .attr("y", d => y(d.NUM))
      .attr("width", x.bandwidth())
      .attr("height", (d) => this.height - y(0))
      .attr('fill', (d, i) => (colors(i)))
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials: " + d.target.__data__.NUM + "<br/>" + "Phase: " + d.target.__data__.Phase)
          .style("left", (d.screenX) + "px")
          .style("top", (d.screenY - 28) + "px")
          .style("position", "absolete")
          .style("background", "#1d2b29")
          .style("color", "#ffffff")
          .style("padding", "2px")
          .style("border-radius", "8px")
          .style("font", " 12px")
          .style("text-align", "center");
      })
      .on("mouseout", function (d) {
        d3.select(this)
          .style("cursor", "default");
        div.transition()
          .duration(500)
          .style("opacity", 0);
      });

    // Animation
    this.svg.selectAll("rect")
      .transition()
      .duration(800)
      .attr("y", d => y(d.NUM))
      .attr("height", (d) => this.height - y(d.NUM))
      .delay(function (d, i) {  return (i * 100) })

  }

  private createDoughnutChart(data: any[]) {
    const svg = d3.select("figure#studyType").append("svg")
      .attr("width", this.width + (this.margin * 2))
      .attr("height", this.height + (this.margin * 2))
      .append("g")
      .attr("transform", "translate(" + this.margin * 6 + "," + this.margin * 4 + ")");

    var radius = Math.min(this.width + (this.margin * 2), this.height + (this.margin * 2)) / 2 - this.margin

    // set the color scale
    var color = d3.scaleOrdinal()
      .domain(data.map(d => d.StudyType))
      .range(["#04BF9D", "#3E372A", "#2CB199", "#7D735F"]);
    //.range(d3.schemeDark2);

    var numData = data.map(d => d.NUM);
    // Compute the position of each group on the pie:
    var pie = d3.pie()
      .sort(null) // Do not sort group by size
      .value(function (d) { return (d as any).NUM; })
    var data_ready = pie(data)

    // The arc generator
    var arc = d3.arc()
      .innerRadius(radius * 0.5)         // This is the size of the donut hole
      .outerRadius(radius * 0.8)

    // Another arc that won't be drawn. Just for labels positioning
    var outerArc = d3.arc()
      .innerRadius(radius * 0.9)
      .outerRadius(radius * 0.9)

    // Build the pie chart: Basically, each part of the pie is a path that we build using the arc function.
    svg
      .selectAll('allSlices')
      .data(data_ready)
      .enter()
      .append('path')
      .attr('d', arc as any)
      .attr('fill', function (d) { return (color((d.data as any).StudyType)) as any})//bilo key
      .attr("stroke", "white")
      .style("stroke-width", "2px")
      .style("opacity", 0.7);

    // Add the polylines between chart and labels:
    svg
      .selectAll('allPolylines')
      .data(data_ready)
      .enter()
      .append('polyline')
      .attr("stroke", "#3E372A")
      .style("fill", "none")
      .attr("stroke-width", 1)
      .attr('points', function (d) {
        var posA = arc.centroid(d) // line insertion in the slice
        var posB = outerArc.centroid(d) // line break: we use the other arc generator that has been built only for that
        var posC = outerArc.centroid(d); // Label position = almost the same as posB
        var midangle = d.startAngle + (d.endAngle - d.startAngle) / 2 // we need the angle to see if the X position will be at the extreme right or extreme left
        posC[0] = radius * 0.5 * (midangle < Math.PI ? 1 : -1); // multiply by 1 or -1 to put it on the right or on the left
        return [posA, posB, posC]
      } as any);


    var total = data.reduce((a, b) => +a + +b.NUM, 0);

    // Add the text:
    svg
      .selectAll('allLabels')
      .data(data_ready)
      .enter()
      .append('text')
      .text(function (d) { return (d.data as any).StudyType + " " + (100 * ((d.data as any).NUM / total)).toFixed(2) + "%" })
      .style("fill", "#25A18A")
      .attr('transform', function (d) {
        var pos = outerArc.centroid(d as any);
        var midangle = d.startAngle + (d.endAngle - d.startAngle) / 2
        pos[0] = radius * 0.6 * (midangle < Math.PI ? 1 : -1);
        return 'translate(' + pos + ')';
      })/*
    .attr("transform", function (d) {
      var pos = outerArc.centroid(d);
      pos[1] = pos[1] - 10;
      var midangle = d.startAngle + (d.endAngle - d.startAngle) / 2
      pos[0] = radius * 0.50 * (midangle < Math.PI ? 1 : -1);
      return "translate(" + pos + ") ";
    })*/
      .attr("dy", 5)
      .style('text-anchor', function (d) {
        var midangle = d.startAngle + (d.endAngle - d.startAngle) / 2
        return (midangle < Math.PI ? 'start' : 'end')
      })
  }

  private createLineChart(data: any[]) {
    const svg = d3.select("figure#trialsByYear").append("svg")
      .attr("width", this.width + (this.margin * 2))
      .attr("height", this.height + (this.margin * 2))
      .append("g")
      .attr("transform", "translate(" + this.margin + "," + this.margin + ")");

    //sorted array
    var sortedYears: any[] = data.sort((n1, n2) => n1.year - n2.year);

    const x = d3.scaleBand()
      .range([0, this.width])
      .domain(sortedYears.map(d => d.year))
      .padding(0.4);

    svg.append("g")
      .attr("transform", "translate(0," + this.height + ")")
      .call(d3.axisBottom(x))
      .selectAll("text")
      .attr("transform", "translate(-10,0)rotate(-20)")
      .style("text-anchor", "end");

    // Create the Y-axis band scale
    const y = d3.scaleLinear()
      .domain([0, d3.max(data, function (d) { return d.NUM + 10; })])
      .range([this.height, 0]);

    // Draw the Y-axis on the DOM
    svg.append("g")
      .call(d3.axisLeft(y));


    var line = d3.line()
      .curve(d3.curveCatmullRom)
      .x(d => x((d as any).year))
      .y(d => y((d as any).NUM))

    // Define the length of line
    const l = (line(sortedYears)).length;

    // Define the div for the tooltip
    var div = d3.select("body").append("div")
      .attr("class", "tooltip")
      .style("opacity", 0);

    svg.append("path")
      .datum(sortedYears)
      .attr("fill", "none")
      .attr("stroke", "#2cb199")
      .attr("stroke-width", 2.5)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line)
      .transition()
      .duration(5000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);

    svg.append("g")
      .attr("fill", "#2cb199")
      .attr("stroke", "white")
      .attr("stroke-width", 3)
      .selectAll("circle")
      .data(sortedYears)
      .join("circle")
      .attr("cx", d => x(d.year))
      .attr("cy", d => y(d.NUM))
      .attr("r", 5.5)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer")
          .attr("fill", "white")
          .attr("stroke", "#2cb199");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials: " + d.target.__data__.NUM + "<br/>" + "Year: " + d.target.__data__.year)
          .style("left", (d.screenX) + "px")
          .style("top", (d.screenY - 28) + "px")
          .style("position", "absolete")
          .style("background", "#1d2b29")
          .style("color", "#ffffff")          
          .style("padding", "2px")
          .style("border-radius", "8px")
          .style("font", " 12px")
          .style("text-align", "center");
      })
      .on("mouseout", function (d) {
        d3.select(this)
          .style("cursor", "default")
          .attr("fill", "#2cb199")
          .attr("stroke", "white");
        div.transition()
          .duration(500)
          .style("opacity", 0);
      });

    const label = svg.append("g")
      .attr("font-family", "sans-serif")
      .attr("font-size", 10)
      .selectAll("g")
      .data(sortedYears)
      .join("g")
      .attr("transform", d => `translate(${x(d.year)},${y(d.NUM)})`)
      .attr("opacity", 0)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials: " + d.target.__data__.NUM + "<br/>" + "Year: " + d.target.__data__.year)
          .style("left", (d.screenX) + "px")
          .style("top", (d.screenY - 28) + "px")
          .style("position", "absolete")
          .style("background", "#1d2b29")
          .style("color", "#ffffff")          
          .style("padding", "2px")
          .style("border-radius", "8px")
          .style("font", " 12px")
          .style("text-align", "center");
      })
      .on("mouseout", function (d) {
        d3.select(this)
          .style("cursor", "default");

        div.transition()
          .duration(500)
          .style("opacity", 0);
      });;

    label.append("text")
      .text(d => d.NUM)
      .call(this.halo);

    label.transition()
      .delay((d, i) => (line(data.slice(0, i + 1))).length / l * (5000 - 125))
      .attr("opacity", 1);

  }

  private halo(text) {
    text.select(function () { return this.parentNode.insertBefore(this.cloneNode(true), this); })
      .attr("fill", "none")
      .attr("stroke", "white")
      .attr("stroke-width", 4)
      .attr("stroke-linejoin", "round");
  }


}
