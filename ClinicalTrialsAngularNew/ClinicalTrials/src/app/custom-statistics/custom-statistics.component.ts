import { Component, OnInit } from '@angular/core';
import { curveMonotoneX, DSVParsedArray } from 'd3';
import d3 = require('d3');
import { StatisticsService } from '../services/statistics-service';

@Component({
  selector: 'app-custom-statistics',
  templateUrl: './custom-statistics.component.html',
  styleUrls: ['./custom-statistics.component.css']
})

export class CustomStatisticsComponent implements OnInit {
  private margin = 50;
  private width = 1350 - (this.margin * 2);
  private height = 400 - (this.margin * 2);
  
  constructor(private _statisticsService: StatisticsService) { }

  ngOnInit(): void {
    
    this.createDayChart();
    this.createMonthChart();
    this.createQuarterChart();
    //this.createSliderSvg();
    this.createYearChart();

    /*this._statisticsService.getChart('/interventionalStudies').subscribe(data => {
      if(data != null)

    });*/
    
  }

  private createDayChart(){
    d3.csv("../assets/studydays.csv").then(function( data) {
      let margin = 50;
      let width = 1350 - (margin * 2);
      let height = 400 - (margin * 2);

      //sorted array
      var sortedYears: any[] = data.sort((n1, n2) => (n1 as any).Year - (n2 as any).Year);
      
      const zoom = d3.zoom()
      .scaleExtent([1, 32])
      .extent([[margin, 0], [width - margin, height]])
      .translateExtent([[margin, -Infinity], [width - margin, Infinity]])
      .on("zoom", zoomed);
      
      const svg = d3.select("figure#interventionalTrialsDay").append("svg")
      //.attr("width", width + margin + margin)
      //.attr("height", height + margin + margin)
      //.attr("viewBox", [0, 0, width , height + (margin * 3)] as any);
      .attr("width", width + (margin * 2))
      .attr("height", height + (margin * 3))
      .append("g")
      .attr("pointer-events", "all")
      .attr("transform", "translate(" + 0 + "," + margin + ")")

      // Add a clipPath: everything out of this area won't be drawn.
      var clip = svg.append("defs").append("svg:clipPath")
        .attr("id", "clip")
        .append("svg:rect")
        .attr("width", width )
        .attr("height", height )
        .attr("x", 0)
        .attr("y", 0);

      var customTimeFormat = timeFormat([
        
        [d3.timeFormat("%d.%m.%Y."), function() { return true; }],

        //[d3.timeFormat("%Y"), function() { return true; }],
        //[d3.timeFormat("%b"), function(d) { return d.getMonth(); }],
        [function()
          {return "";}, function(d) { return d.getDate() != 1; }
        ]
      ]);

      const x = d3.scaleTime()
        .range([0, width])
        .domain([d3.min(data, (d) => new Date((data[0] as any).Year)), 
        d3.max(data, (d) => new Date((data[data.length-1] as any).Year))]);

      const xAxis = d3.axisBottom(x)
        //.tickFormat(d3.timeFormat("%d.%m.%Y."))
        //.tickFormat(customTimeFormat)
        .ticks(width / 80).tickSizeOuter(0)
        //.ticks(d3.timeMonth.every(1));

      var gX = svg.append("g")    
        .attr("transform", "translate(" + margin + "," + height + ")")
        .call(xAxis)
        .style("color", "#0000e6")
        //.selectAll("text")
        //.attr("transform", "translate(-10,0)rotate(-70)")
        .style("text-anchor", "end")
        .style("font-size", "10px");
        
      
      const maxInterventional = Math.max.apply(Math, data.map(function(o) { return o.Interventional; }));
      // Create the Y-axis band scale
      const y = d3.scaleLinear()
        .domain([0, maxInterventional])
        .range([height, 0]);

      // Draw the Y-axis on the DOM
      var gY = svg.append("g")
        .attr("transform", `translate(${margin},0)`)
        .call(d3.axisLeft(y))
        .style("color", "#0000e6");
    
      var line = (data, x) => d3.line()
        .curve(d3.curveCatmullRom)
        .x(d => x(new Date((d as any).Year)))
        .y(d => y((d as any).Interventional))
       
     

      var lineExp = (data, x) => d3.line()
        .curve(d3.curveCatmullRom)
        .x(d => x(new Date((d as any).Year)))
        .y(d => y((d as any).ExpandedAccess))
          
      // Define the length of line
      const l = (line(sortedYears, x)).length;

      var path = svg.append("path")
      .attr("clip-path", "url(#clip)")
      .datum(sortedYears)
      .attr("transform", "translate(" + margin + "," + 0 + ")")
      .attr("fill", "none")
      .attr("stroke", "#cc0099")
      .attr("stroke-width", 0.8)
      .attr("stroke-linejoin", "round")
      //.attr("stroke-linecap", "round")
      //.attr("stroke-dasharray", `0,${l}`)
      .attr("d", line(sortedYears, x)) 
      /*.transition()
      .duration(1000)
      .ease(d3.easeLinear)*/
      //.attr("stroke-array", `${l},${l}`);
      .attr("stroke-linecap", "round");

     

      var pathExp = svg.append("path")
      .attr("clip-path", "url(#clip)")
      .datum(sortedYears)
      .attr("transform", "translate(" + margin + "," + 0 + ")")
      .attr("fill", "none")
      .attr("stroke", "#1874CD")
      .attr("stroke-width", 0.8)
      .attr("stroke-linejoin", "round")
     .attr("d", lineExp(sortedYears, x)) 
      .attr("stroke-linecap", "round");

      svg.call(zoom)
        .transition()
        .duration(750)
        .call(zoom.scaleTo, 14, [x(new Date(2005, 8, 1)), 0]);
        
      
      function zoomed(event) {
        const xz = event.transform.rescaleX(x);
        path.attr("d", line(data, xz));
        pathExp.attr("d", lineExp(data, xz));
        gX.call(xAxis.scale(xz));
      }
    
      function timeFormat(formats) {
        return function(date) {
          var i = formats.length - 1, f = formats[i];
          while (!f[1](date)) f = formats[--i];
          return f[0](date);
        };
      }
      /*
      var customTimeFormat = timeFormat([
        [d3.timeFormat("%Y"), function() { return true; }],
        [d3.timeFormat("%b"), function(d) { return d.getMonth(); }],
        [function(){return "";}, function(d) { return d.getDate() != 1; }]
      ]);*/

      // Define the div for the tooltip
      var div = d3.select("body").append("div")
        .attr("class", "tooltip")
        .style("opacity", 0);

      svg.append("g")
        .style("fill","none")
        .style("stroke","none")
        .selectAll("circle")
        .data(sortedYears)
        .join("circle")
        .attr("cx", d => x(new Date((d as any).Year)))
        .attr("cy", d => y(d.Interventional))
        .attr("r", 15.5)
        .style("pointer-events","all")
        .on("mouseover", function (d) {
          d3.select(this)
            .style("cursor", "pointer")
            //.attr("fill", "white")
            //.attr("stroke", "#2cb199");
          div.transition()
            .duration(200)
            .style("opacity", .9);
          div.html("Number of interventional trials: " + d.target.__data__.Interventional + "<br/>" + "Date: " + d.target.__data__.Year)
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
            //.attr("fill", "#2cb199")
            //.attr("stroke", "white");
          div.transition()
            .duration(500)
            .style("opacity", 0);
        });

        svg.append("text")
        .attr("text-anchor", "end")
        .style('fill', '#0000ff')
        .attr("x", 0)
        .attr("y", -30 )
        .text("Number of interventional trials")
        .attr("text-anchor", "start")
    
        svg.append("text")
        .attr("text-anchor", "end")
        .text("Date")    
        .style('fill', '#0000ff')
        .attr("text-anchor", "start")
        .attr("transform",
              "translate(" + (width/2) + " ," + 
                       (height + margin + 30) + ")")

      svg.append("text")
      .attr("x", (width/2 - 10))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("Studies by day (zoom in)") 
      .style('fill', '#0000ff');
    
    });

  }

  private createMonthChart(){

    d3.csv("../assets/studymonths.csv").then(function( data) {
      let margin = 50;
      let width = 1350 - (margin * 2);
      let height = 400 - (margin * 2);

      //sorted array
      var sortedYears: any[] = data.sort((n1, n2) => (n1 as any).Month - (n2 as any).Month);

      const svg = d3.select("figure#interventionalTrialsMonth").append("svg")
      .attr("width", width + (margin * 2))
      .attr("height", height + (margin * 3))
      .append("g")
      .attr("transform", "translate(" + margin + "," + margin + ")")
      
      svg.append("text")
      .attr("x", (width/2 - 10))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("Studies by month") 
      .style('fill', '#0000ff');

      const x = d3.scaleTime()
        .range([0, width])
        .domain([d3.min(data, (d) => new Date((data[0] as any).Month)), d3.max(data, (d) => new Date((data[data.length-1] as any).Month))]);

      const xAxis = d3.axisBottom(x)
        .tickFormat(d3.timeFormat("%d.%m.%Y.")).ticks(d3.timeMonth.every(3));

      var gX = svg.append("g")    
        .attr("transform", "translate(0," + height + ")")
        .call(xAxis)
        .style("color", "#0000e6")
        .selectAll("text")
        .attr("transform", "translate(-10,0)rotate(-70)")
        .style("text-anchor", "end")
        .style("font-size", "10px");


      const maxInterventional = Math.max.apply(Math, data.map(function(o) { return o.Interventional; }));
      // Create the Y-axis band scale
      const y = d3.scaleLinear()
        .domain([0, maxInterventional])
        .range([height, 0]);

      // Draw the Y-axis on the DOM
      var gY = svg.append("g")
        .call(d3.axisLeft(y))
        .style("color", "#0000e6");
    
      var line = d3.line()
      .curve(d3.curveCatmullRom)
      .x(d => x(new Date((d as any).Month)))
      .y(d => y((d as any).Interventional))

      // Define the length of line
      const l = (line(sortedYears)).length;

      var path = svg.append("path")
      .datum(sortedYears)
      .attr("fill", "none")
      .attr("stroke", "#cc0099")
      .attr("stroke-width", 1.9)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line) 
      .transition()
      .duration(50000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);

      var axis = svg.append("g")
      .attr("transform", "translate(0," + height + ")")
      .style("color", "#0000e6")
      .style("text-anchor", "end")
      .style("font-size", "10px")

      // Define the div for the tooltip
      var div = d3.select("body").append("div")
        .attr("class", "tooltip")
        .style("opacity", 0);

        svg.append("g")
        .attr("fill", "#cc0099")
        .attr("stroke", "white")
        .attr("stroke-width", 1)
        .selectAll("circle")
        .data(sortedYears)
        .join("circle")
        .attr("cx", d => x(new Date((d as any).Month)))
        .attr("cy", d => y(d.Interventional))
        .attr("r", 2.5)
        .on("mouseover", function (d) {
          d3.select(this)
            .style("cursor", "pointer")
            .attr("fill", "white")
            .attr("stroke", "#cc0099");
          div.transition()
            .duration(200)
            .style("opacity", .9);
          div.html("Number of interventional trials: " + d.target.__data__.Interventional + "<br/>" + "Date: " + d.target.__data__.Month)
            .style("left", (d.pageX) + "px")
            .style("top", (d.pageY ) + "px")
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
            .attr("fill", "#cc0099")
            .attr("stroke", "white");
          div.transition()
            .duration(500)
            .style("opacity", 0);
        });

        svg.append("text")
        .attr("text-anchor", "end")
        .style('fill', '#0000ff')
        .attr("x", 0)
        .attr("y", -30 )
        .text("Number of interventional trials")
        .attr("text-anchor", "start")
    
        svg.append("text")
        .attr("text-anchor", "end")
        .text("Date")    
        .style('fill', '#0000ff')
        .attr("text-anchor", "start")
        .attr("transform",
              "translate(" + (width/2) + " ," + 
                       (height + margin + 30) + ")")
    
    });
  }

  private createQuarterChart(){
    d3.csv("../assets/studytypeQ.csv").then(function( data) {
      let margin = 50;
      let width = 1350 - (margin * 2);
      let height = 400 - (margin * 2);

      //sorted array
      var sortedYears: any[] = data.sort((n1, n2) => (n1 as any).Month - (n2 as any).Month);

      const svg = d3.select("figure#interventionalTrialsQ").append("svg")
      .attr("width", width + (margin * 2))
      .attr("height", height + (margin * 3))
      .append("g")
      .attr("transform", "translate(" + margin + "," + margin + ")")
      

      const x = d3.scaleBand()
      .range([0, width])
      .domain(sortedYears.map(d => d.Month))
      //.padding(0.4);

      svg.append("g")    
        .attr("transform", "translate(0," + height + ")")
        .call(d3.axisBottom(x))
        .style("color", "#0000e6")
        .selectAll("text")
        .attr("transform", "translate(-10,0)rotate(-70)")
        .style("text-anchor", "end")
        .style("font-size", "10px");


      const maxInterventional = Math.max.apply(Math, data.map(function(o) { return o.Interventional; }));
      // Create the Y-axis band scale
      const y = d3.scaleLinear()
        .domain([0, maxInterventional])
        .range([height, 0]);

      // Draw the Y-axis on the DOM
      svg.append("g")
        .call(d3.axisLeft(y))
        .style("color", "#0000e6");
    
      var line = d3.line()
      .curve(d3.curveCatmullRom)
      .x(d => x((d as any).Month))
      .y(d => y((d as any).Interventional))

      // Define the length of line
      const l = (line(sortedYears)).length;

      var path = svg.append("path")
      .datum(sortedYears)
      .attr("fill", "none")
      .attr("stroke", "#cc0099")
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line) 
      .transition()
      .duration(20000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);

      var axis = svg.append("g")
      .attr("transform", "translate(0," + height + ")")
      .style("color", "#0000e6")
      .style("text-anchor", "end")
      .style("font-size", "10px")

      // Define the div for the tooltip
      var div = d3.select("body").append("div")
        .attr("class", "tooltip")
        .style("opacity", 0);

        svg.append("g")
        .attr("fill", "#cc0099")
        .attr("stroke", "white")
        .attr("stroke-width", 1)
        .selectAll("circle")
        .data(sortedYears)
        .join("circle")
        .attr("cx", d => x((d as any).Month))
        .attr("cy", d => y(d.Interventional))
        .attr("r", 2.5)
        .on("mouseover", function (d) {
          d3.select(this)
            .style("cursor", "pointer")
            .attr("fill", "white")
            .attr("stroke", "#cc0099");
          div.transition()
            .duration(200)
            .style("opacity", .9);
          div.html("Number of interventional trials: " + d.target.__data__.Interventional + "<br/>" + "Date: " + d.target.__data__.Month)
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
            .style("cursor", "default")
            .attr("fill", "#cc0099")
            .attr("stroke", "white");
          div.transition()
            .duration(500)
            .style("opacity", 0);
        });

        svg.append("text")
        .attr("text-anchor", "end")
        .style('fill', '#0000ff')
        .attr("x", 0)
        .attr("y", -30 )
        .text("Number of interventional trials")
        .attr("text-anchor", "start")
    
        svg.append("text")
        .attr("text-anchor", "end")
        .text("Date")    
        .style('fill', '#0000ff')
        .attr("text-anchor", "start")
        .attr("transform",
              "translate(" + (width/2) + " ," + 
                       (height + margin + 30) + ")")
      
      svg.append("text")
      .attr("x", (width/2 - 10))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("Studies by quarter-year") 
      .style('fill', '#0000ff');
    
    });
  }

  private createYearChart() {
    d3.csv("../assets/studyyears.csv").then(function( data) {
      let margin = 50;
      let width = 1350 - (margin * 2);
      let height = 400 - (margin * 2);

      //sorted array
      var sortedYears: any[] = data.sort((n1, n2) => (n1 as any).Year - (n2 as any).Year);

      const svg = d3.select("figure#interventionalTrialsYear").append("svg")
      .attr("width", width + (margin * 2))
      .attr("height", height + (margin * 3))
      .append("g")
      .attr("transform", "translate(" + margin + "," + margin + ")")
      

      const x = d3.scaleBand()
      .range([0, width])
      .domain(sortedYears.map(d => d.Year))
      //.padding(0.4);

      svg.append("g")    
        .attr("transform", "translate(0," + height + ")")
        .call(d3.axisBottom(x))
        .style("color", "#0000e6")
        .selectAll("text")
        .attr("transform", "translate(-10,0)rotate(-70)")
        .style("text-anchor", "end")
        .style("font-size", "10px");


      const maxInterventional = Math.max.apply(Math, data.map(function(o) { return o.Interventional; }));
      // Create the Y-axis band scale
      const y = d3.scaleLinear()
        .domain([0, maxInterventional])
        .range([height, 0]);

      // Draw the Y-axis on the DOM
      svg.append("g")
        .call(d3.axisLeft(y))
        .style("color", "#0000e6");
    
      var line = d3.line()
      .curve(d3.curveCatmullRom)
      .x(d => x((d as any).Year))
      .y(d => y((d as any).Interventional))

      var lineObs = d3.line()
      .curve(d3.curveCatmullRom)
      .x(d => x((d as any).Year))
      .y(d => y((d as any).Observational))
      
      var lineExp = d3.line()
      .curve(d3.curveCatmullRom)
      .x(d => x((d as any).Year))
      .y(d => y((d as any).ExpandedAccess))


      // Define the length of line
      const l = (line(sortedYears)).length + 10;

      var path = svg.append("path")
      .datum(sortedYears)
      .attr("fill", "none")
      .attr("stroke", "#cc0099")
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line) 
      .transition()
      .duration(9000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);

      var pathObs = svg.append("path")
      .datum(sortedYears)
      .attr("fill", "none")
      .attr("stroke", "#6495ED")
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", lineObs) 
      .transition()
      .duration(9000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);

      var pathExp = svg.append("path")
      .datum(sortedYears)
      .attr("fill", "none")
      .attr("stroke", "#6600cc")
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", lineExp) 
      .transition()
      .duration(9000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);

      var axis = svg.append("g")
      .attr("transform", "translate(0," + height + ")")
      .style("color", "#0000e6")
      .style("text-anchor", "end")
      .style("font-size", "10px")

      // Define the div for the tooltip
      var div = d3.select("body").append("div")
        .attr("class", "tooltip")
        .style("opacity", 0);

      /////////////////////////////////////

        svg.append("g")
        .attr("fill", "#cc0099")
        .attr("stroke", "white")
        .attr("stroke-width", 1.5)
        .selectAll("circle")
        .data(sortedYears)
        .join("circle")
        .attr("cx", d => x((d as any).Year))
        .attr("cy", d => y(d.Interventional))
        .attr("r", 3.5)
        .on("mouseover", function (d) {
          d3.select(this)
            .style("cursor", "pointer")
            .attr("fill", "white")
            .attr("stroke", "#cc0099");
          div.transition()
            .duration(200)
            .style("opacity", .9);
          div.html("Number of interventional trials: " + d.target.__data__.Interventional + "<br/>" + "Date: " + d.target.__data__.Year)
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
            .style("cursor", "default")
            .attr("fill", "#cc0099")
            .attr("stroke", "white");
          div.transition()
            .duration(500)
            .style("opacity", 0);
        });

      
      svg.append("text")
      .attr("x", (width/2 - 10))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("Studies by year") 
      .style('fill', '#0000ff');
       
      /////////////////////////////////////

      svg.append("g")
      .attr("fill", "#6495ED")
      .attr("stroke", "white")
      .attr("stroke-width", 1.5)
      .selectAll("circle")
      .data(sortedYears)
      .join("circle")
      .attr("cx", d => x((d as any).Year))
      .attr("cy", d => y(d.Observational))
      .attr("r", 3.5)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer")
          .attr("fill", "white")
          .attr("stroke", "#6495ED");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of observational trials: " + d.target.__data__.Observational + "<br/>" + "Date: " + d.target.__data__.Year)
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
          .style("cursor", "default")
          .attr("fill", "#6495ED")
          .attr("stroke", "white");
        div.transition()
          .duration(500)
          .style("opacity", 0);
      });

     
      svg.append("text")
      .attr("x", (width/2 - 10))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("Studies by year") 
      .style('fill', '#0000ff');
      /////////////////

      svg.append("g")
      .attr("fill", "#6600cc")
      .attr("stroke", "white")
      .attr("stroke-width", 1.5)
      .selectAll("circle")
      .data(sortedYears)
      .join("circle")
      .attr("cx", d => x((d as any).Year))
      .attr("cy", d => y(d.ExpandedAccess))
      .attr("r", 3.5)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer")
          .attr("fill", "white")
          .attr("stroke", "#6600cc");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials with expanded access: " + d.target.__data__.ExpandedAccess + "<br/>" + "Date: " + d.target.__data__.Year)
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
          .style("cursor", "default")
          .attr("fill", "#6600cc")
          .attr("stroke", "white");
        div.transition()
          .duration(500)
          .style("opacity", 0);
      });

      svg.append("text")
      .attr("text-anchor", "end")
      .style('fill', '#0000ff')
      .attr("x", 0)
      .attr("y", -30 )
      .text("Number of trials")
      .attr("text-anchor", "start")
  
      svg.append("text")
      .attr("text-anchor", "end")
      .text("Date")    
      .style('fill', '#0000ff')
      .attr("text-anchor", "start")
      .attr("transform",
            "translate(" + (width/2) + " ," + 
                     (height + margin + 30) + ")")
    
      svg.append("text")
      .attr("x", (width/2 - 10))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("Studies by year") 
      .style('fill', '#0000ff');



      ///////////////

      const label = svg.append("g")
      .attr("font-family", "sans-serif")
      .attr("font-size", 10)
      .selectAll("g")
      .data(sortedYears)
      .join("g")
      .attr("transform", d => `translate(${x(d.Year)},${y(d.Interventional)-15})`)
      .attr("opacity", 0)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials: " + d.target.__data__.Interventional + "<br/>" + "Year: " + d.target.__data__.Year)
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


      label.append("text")
      .text(d => d.Interventional)
      .call(halo);

      label.transition()
        .delay((d, i) => (line((data as any).slice(0, i + 1))).length / l * (5000 - 125))
        .attr("opacity", 1);



      const labelObs = svg.append("g")
      .attr("font-family", "sans-serif")
      .attr("font-size", 10)
      .selectAll("g")
      .data(sortedYears)
      .join("g")
      .attr("transform", d => `translate(${x(d.Year)},${y(d.Observational)-15})`)
      .attr("opacity", 0)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials: " + d.target.__data__.Observational + "<br/>" + "Year: " + d.target.__data__.Year)
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


      labelObs.append("text")
      .text(d => d.Observational)
      .call(halo);

      labelObs.transition()
        .delay((d, i) => (line((data as any).slice(0, i + 1))).length / l * (5000 - 125))
        .attr("opacity", 1);

      /////////////////////////////
      const labelExp = svg.append("g")
      .attr("font-family", "sans-serif")
      .attr("font-size", 10)
      .selectAll("g")
      .data(sortedYears)
      .join("g")
      .attr("transform", d => `translate(${x(d.Year)},${y(d.ExpandedAccess)-7})`)
      .attr("opacity", 0)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of trials: " + d.target.__data__.ExpandedAccess + "<br/>" + "Year: " + d.target.__data__.Year)
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


      labelExp.append("text")
      .text(d => d.ExpandedAccess)
      .call(halo);

      labelExp.transition()
        .delay((d, i) => (line((data as any).slice(0, i + 1))).length / l * (5000 - 125))
        .attr("opacity", 1);

      function halo(text) {
        text.select(function () { return this.parentNode.insertBefore(this.cloneNode(true), this); })
          .attr("stroke-width", .1)
          .style('fill', '#3333ff')
          .attr("stroke-linejoin", "round");
      }
    });
  }
  
  private halo(text) {
    text.select(function () { return this.parentNode.insertBefore(this.cloneNode(true), this); })
      .attr("stroke-width", .1)
      .style('fill', '#3333ff')
      .attr("stroke-linejoin", "round");
      
  }

  private async createSliderSvg(){
   
  }
}
