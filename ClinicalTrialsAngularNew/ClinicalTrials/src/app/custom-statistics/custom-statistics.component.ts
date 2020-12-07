import { Component, OnInit } from '@angular/core';
import { curveMonotoneX, DSVParsedArray } from 'd3';
import d3 = require('d3');
import { StatisticsService } from '../services/statistics-service';
import { DecimalPipe } from '@angular/common';
import { runInThisContext } from 'vm';

@Component({
  selector: 'app-custom-statistics',
  templateUrl: './custom-statistics.component.html',
  styleUrls: ['./custom-statistics.component.css']
})

export class CustomStatisticsComponent implements OnInit {
  private margin = 50;
  private width = 1350 - (this.margin * 2);
  private height = 400 - (this.margin * 2);
  public showRegression =  false;

  regressionObservationalMonthsPol : any[] = [];
  regressionObservationalMonthsLin : any[] = [];
  regressionInterventionalMonthsPol : any[] = [];
  regressionInterventionalMonthsLin : any[] = [];
  regressionExpandedAccessMonthsPol : any[] = [];
  regressionExpandedAccessMonthsLin : any[] = [];

  regressionObservationalYearsPol : any[] = [];
  regressionObservationalYearsLin : any[] = [];
  regressionInterventionalYearsPol : any[] = [];
  regressionInterventionalYearsLin : any[] = [];
  regressionExpandedAccessYearsPol : any[] = [];
  regressionExpandedAccessYearsLin : any[] = [];

  regressionObservationalDaysPol : any[] = [];
  regressionObservationalDaysLin : any[] = [];
  regressionInterventionalDaysPol : any[] = [];
  regressionInterventionalDaysLin : any[] = [];
  regressionExpandedAccessDaysPol : any[] = [];
  regressionExpandedAccessDaysLin : any[] = [];

  constructor(private _statisticsService: StatisticsService) { }

  ngOnInit(): void {
    this.createDayChart();
    this.createMonthChart();
    this.createQuarterChart();
    this.createYearChart();

    this.getRegressionYears();
  }

  toggleRegression(event){
    event.preventDefault();
    this.showRegression = !this.showRegression;

    if(this.showRegression)
      if(this.regressionInterventionalYearsPol.length === 0)
        this.getRegressionYears();
      else {
        this.createYearChartR();
      }
  }
  
  public createMonthChartR(){
    d3.select("figure#TrialsR").selectAll("g").remove();
   
      let margin = 50;
      let width = 1350 - (margin * 2);
      let height = 400 - (margin * 2);
      
      const zoom = d3.zoom()
      .scaleExtent([1, 32])
      .extent([[margin, 0], [width - margin, height]])
      .translateExtent([[margin, -Infinity], [width - margin, Infinity]])
      .on("zoom", zoomed);
      
      const svg = d3.select("figure#TrialsR").select("svg")
      .attr("width", width + (margin * 2))
      .attr("height", height + (margin * 3))
      .append("g")
      .attr("pointer-events", "all")
      .attr("transform", "translate(" + margin + "," + margin + ")")
      //.call(zoom)
      
      const x = d3.scaleBand()
      .range([0, width])
      .domain(this.regressionInterventionalMonthsPol.map(d => d.Date));
 
      
      var xAxis = d3.axisBottom(x).tickValues(x.domain().filter((d, i) => (d as any) % 10 === 0));

      var gX = svg.append("g")    
        .attr("transform", "translate(0," + height + ")")
        .call(xAxis)
        .style("color", "#0000e6")
        .selectAll("text")
        .style("text-anchor", "end")
        .style("font-size", "10px");

        const maxI = Math.max.apply(Math, this.regressionInterventionalMonthsPol.map(function(o) { return o.NUM; }));
        const maxO = Math.max.apply(Math, this.regressionObservationalMonthsPol.map(function(o) { return o.NUM; }));
        const maxExp = Math.max.apply(Math, this.regressionExpandedAccessMonthsPol.map(function(o) { return o.NUM; }));

        // Create the Y-axis band scale
        const y = d3.scaleLinear()
          .domain([0, maxI])
          .range([height, 0]);

        // Draw the Y-axis on the DOM
        svg.append("g")
          .call(d3.axisLeft(y))
          .style("color", "#0000e6");
      
        var line = d3.line()
        .curve(d3.curveCatmullRom)
        .x(d => x((d as any).Date))
        .y(d => y((d as any).NUM))

        /*svg.call(zoom)
        .transition()
        .duration(750)
        .call(zoom.scaleTo, 14, [x("50"), 0]);*/
        
      
        /*var line = (data, x) => d3.line()
        .curve(d3.curveCatmullRom)
        .x(d => x((d as any).Date))
        .y(d => y((d as any).NUM))*/
                
        // Define the length of line
        /*const lInt = (line(this.regressionInterventionalMonths, x)).length;
        const lExp = (line(this.regressionExpandedAccessMonths, x)).length + 10;
        const lObs = (line(this.regressionObservationalMonths, x)).length + 10;
        */
        const lInt = (line(this.regressionInterventionalMonthsPol)).length;
        const lExp = (line(this.regressionExpandedAccessMonthsPol)).length + 10;
        const lObs = (line(this.regressionObservationalMonthsPol)).length + 10;
        
        var pathInt = svg.append("path")
        .datum(this.regressionInterventionalMonthsPol)
        .attr("fill", "none")
        .attr("stroke", "#cc0099")
        .attr("stroke-width", 2)
        .attr("stroke-linejoin", "round")
        .attr("stroke-linecap", "round")
        .attr("stroke-dasharray", `0,${lInt}`)
        .attr("d", line(this.regressionInterventionalMonthsPol)) 
        .transition()
        .duration(30000)
        .ease(d3.easeLinear)
        .attr("stroke-dasharray", `${lInt},${lInt}`);

        // Define the div for the tooltip
        var div = d3.select("body").append("div")
          .attr("class", "tooltip")
          .style("opacity", 0);
    
        var pathObs = svg.append("path")
        .datum(this.regressionObservationalMonthsPol)
        .attr("fill", "none")
        .attr("stroke", "#6495ED")
        .attr("stroke-width", 2)
        .attr("stroke-linejoin", "round")
        .attr("stroke-linecap", "round")
        .attr("stroke-dasharray", `0,${lObs}`)
        .attr("d", line) 
        .transition()
        .duration(30000)
        .ease(d3.easeLinear)
        .attr("stroke-dasharray", `${lObs},${lObs}`);
  
        var pathExp = svg.append("path")
        .datum(this.regressionExpandedAccessMonthsPol)
        .attr("fill", "none")
        .attr("stroke", "#6600cc")
        .attr("stroke-width", 2)
        .attr("stroke-linejoin", "round")
        .attr("stroke-linecap", "round")
        .attr("stroke-dasharray", `0,${lExp}`)
        .attr("d", line) 
        .transition()
        .duration(30000)
        .ease(d3.easeLinear)
        .attr("stroke-dasharray", `${lExp},${lExp}`);
        
        function zoomed(event) {
          console.log(event)
          const xz = event.transform.rescaleX(x);
          //pathInt.attr("d", line(this.regressionObservationalMonths, xz));
          gX.call(xAxis.scale(xz));
        }

        // Define the div for the tooltip
        var div = d3.select("body").append("div")
          .attr("class", "tooltip")
          .style("opacity", 0);

        /////////////////////////////////////

        this.regressionInterventionalMonthsPol.forEach(element => {
          element.NUM = parseFloat(element.NUM).toFixed(2);
        });

        this.regressionObservationalMonthsPol.forEach(element => {
          element.NUM = parseFloat(element.NUM).toFixed(2);
        });

        this.regressionExpandedAccessMonthsPol.forEach(element => {
          element.NUM = parseFloat(element.NUM).toFixed(2);
        });

        svg.append("g")
        .style("fill","none")
        .style("stroke","none")
        .selectAll("circle")
        .data(this.regressionInterventionalMonthsPol)
        .join("circle")
        .attr("cx", d => x((d as any).Date))
        .attr("cy", d => y(d.NUM))
        .attr("r", 15.5)
        .style("pointer-events","all")
        .on("mouseover", function (d) {
          d3.select(this)
            .style("cursor", "pointer")
          div.transition()
            .duration(200)
            .style("opacity", .9);
          div.html("Number of interventional trials: " + d.target.__data__.NUM + "<br/>" + "Date: " + d.target.__data__.Date)
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
          div.transition()
            .duration(500)
            .style("opacity", 0);
        });

        /////////////////////////////////////
        svg.append("g")
        .style("fill","none")
        .style("stroke","none")
        .selectAll("circle")
        .data(this.regressionObservationalMonthsPol)
        .join("circle")
        .attr("cx", d => x((d as any).Date))
        .attr("cy", d => y(d.NUM))
        .attr("r", 15.5)
        .style("pointer-events","all")
        .on("mouseover", function (d) {
          d3.select(this)
            .style("cursor", "pointer")
          div.transition()
            .duration(200)
            .style("opacity", .9);
          div.html("Number of interventional trials: " + d.target.__data__.NUM + "<br/>" + "Date: " + d.target.__data__.Date)
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
          div.transition()
            .duration(500)
            .style("opacity", 0);
        });

        /////////////////////////////////////
        svg.append("g")
        .style("fill","none")
        .style("stroke","none")
        .selectAll("circle")
        .data(this.regressionExpandedAccessMonthsPol)
        .join("circle")
        .attr("cx", d => x((d as any).Date))
        .attr("cy", d => y(d.NUM))
        .attr("r", 15.5)
        .style("pointer-events","all")
        .on("mouseover", function (d) {
          d3.select(this)
            .style("cursor", "pointer")
          div.transition()
            .duration(200)
            .style("opacity", .9);
          div.html("Number of interventional trials: " + d.target.__data__.NUM + "<br/>" + "Date: " + d.target.__data__.Date)
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
          div.transition()
            .duration(500)
            .style("opacity", 0);
        });

      ////////////////TITLES/////////////////

      svg.append("text")
      .attr("x", (margin))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("Regression by") 
      .style('fill', '#0000ff');


      svg.append("circle")
      .attr("cx", margin + 69)
      .attr("cy", -24)
      .attr("r", 5)
      .attr("stroke", "white")
      .attr("fill", "#6600cc") 
      .on("click", () => this.createYearChartR())
      .on("mouseover", function (d) {
        d3.select(this)
        .style("cursor", "pointer")
        .attr("fill", "white")
        .attr("stroke", "#6600cc");
      })
      .on("mouseout", function (d) {
        d3.select(this)
        .style("cursor", "default")
        .attr("fill", "#6600cc")
        .attr("stroke", "white");
      });

      svg.append("text")
      .attr("x", (margin + 100))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("years") 
      .style('fill', '#0000ff');

      svg.append("circle")
      .attr("cx", margin + 132)
      .attr("cy", -24)
      .attr("r", 5)
      .attr("stroke", "white")
      .attr("fill", "#6495ED") 
      .on("mouseover", function (d) {
        d3.select(this)
        .style("cursor", "pointer")
        .attr("fill", "white")
        .attr("stroke", "#6495ED");
      })
      .on("mouseout", function (d) {
        d3.select(this)
        .style("cursor", "default")
        .attr("fill", "#6495ED")
        .attr("stroke", "white");
      });

      svg.append("text")
      .attr("x", (margin + 171))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("months") 
      .style('fill', '#0000ff');
      

      svg.append("circle")
      .attr("cx", margin + 211)
      .attr("cy", -24)
      .attr("r", 5)
      .attr("stroke", "white")
      .attr("fill", "#3718a7") 
      //.on("click", () => this.createQuarterChartR())
      .on("mouseover", function (d) {
        d3.select(this)
        .style("cursor", "pointer")
        .attr("fill", "white")
        .attr("stroke", "#3718a7");
      })
      .on("mouseout", function (d) {
        d3.select(this)
        .style("cursor", "default")
        .attr("fill", "#3718a7")
        .attr("stroke", "white");
      });

      svg.append("text")
      .attr("x", (margin + 253))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("quarters") 
      .style('fill', '#0000ff');
      
      /////////////////////////////////////
      svg.append("text")
      .attr("text-anchor", "end")
      .text("Date")    
      .style('fill', '#0000ff')
      .attr("text-anchor", "start")
      .attr("transform",
            "translate(" + (width/2) + " ," + 
                    (height + margin + 30) + ")")
    
      
      svg.append("circle")
      .attr("cx", margin + 298)
      .attr("cy", -24)
      .attr("r", 5)
      .attr("stroke", "white")
      .attr("fill", "#295ad9") 
      .on("click", () => this.createDayChartR())
      .on("mouseover", function (d) {
        d3.select(this)
        .style("cursor", "pointer")
        .attr("fill", "white")
        .attr("stroke", "#295ad9");
      })
      .on("mouseout", function (d) {
        d3.select(this)
        .style("cursor", "default")
        .attr("fill", "#295ad9")
        .attr("stroke", "white");
      });

      svg.append("text")
      .attr("x", (margin + 327))             
      .attr("y", -20 )
      .attr("text-anchor", "middle") 
      .style("font-size", "16px") 
      .style("font-weight", "bold")  
      .text("days") 
      .style('fill', '#0000ff');

      /////////////////////////////////////
      svg.append("text")
      .attr("text-anchor", "end")
      .text("Date")    
      .style('fill', '#0000ff')
      .attr("text-anchor", "start")
      .attr("transform", "translate(" + (width/2) + " ," +  (height + margin + 30) + ")")
        
  }

  private getRegressionMonths(){
    this._statisticsService.getRegressionCsv("regressionObservationalMonthsPol").subscribe(dataOP => {
      this.regressionObservationalMonthsPol = dataOP;
      this._statisticsService.getRegressionCsv("regressionObservationalMonthsLin").subscribe(dataOL => {
        this.regressionObservationalMonthsLin = dataOL;
      });
      this._statisticsService.getRegressionCsv("regressionInterventionalMonthsPol").subscribe(dataIP => {
        this.regressionInterventionalMonthsPol = dataIP;
        this._statisticsService.getRegressionCsv("regressionInterventionalMonthsLin").subscribe(dataIL => {
          this.regressionInterventionalMonthsLin = dataIL;
        });
        this._statisticsService.getRegressionCsv("regressionExpandedAccessMonthsPol").subscribe(dataEAP => {
          this.regressionExpandedAccessMonthsPol = dataEAP;
          this._statisticsService.getRegressionCsv("regressionExpandedAccessMonthsLin").subscribe(dataEAL => {
            this.regressionExpandedAccessMonthsLin = dataEAL;
          });
        })
      })
    })
  }

  private getRegressionDays(){
    this._statisticsService.getRegressionCsv("regressionObservationalDaysPol").subscribe(dataOP => {
      this.regressionObservationalDaysPol = dataOP;
      this._statisticsService.getRegressionCsv("regressionObservationalDaysLin").subscribe(dataOL => {
        this.regressionObservationalDaysLin = dataOL;
      });
      this._statisticsService.getRegressionCsv("regressionInterventionalDaysPol").subscribe(dataIP => {
        this.regressionInterventionalDaysPol = dataIP;
        this._statisticsService.getRegressionCsv("regressionInterventionalDaysLin").subscribe(dataIL => {
          this.regressionInterventionalDaysLin = dataIL;
        });
        this._statisticsService.getRegressionCsv("regressionExpandedAccessDaysPol").subscribe(dataEAP => {
          this.regressionExpandedAccessDaysPol = dataEAP;
          this._statisticsService.getRegressionCsv("regressionExpandedAccessDaysLin").subscribe(dataEAL => {
            this.regressionInterventionalDaysLin = dataEAL;
          });
        })
      })
    })
  }

  private createDayChartR(){
    d3.select("figure#TrialsR").selectAll("g").remove();

    let margin = 50;
    let width = 1350 - (margin * 2);
    let height = 400 - (margin * 2);

    const svg = d3.select("figure#TrialsR").select("svg")
    .attr("width", width + (margin * 2))
    .attr("height", height + (margin * 3))
    .append("g")
    .attr("transform", "translate(" + margin + "," + margin + ")")
    

    const x = d3.scaleBand()
    .range([0, width])
    .domain(this.regressionObservationalDaysPol.map(d => d.Date));           
    svg.append("g")    
      .attr("transform", "translate(0," + height + ")")
      .call(d3.axisBottom(x).tickValues(x.domain().filter((d, i) => (d as any) % 500 === 0)))
      .style("color", "#0000e6")
      .selectAll("text")
      .style("text-anchor", "end")
      .style("font-size", "10px");
    
      const maxInterventional = Math.max.apply(Math, this.regressionInterventionalDaysPol.map(function(o) { return o.NUM; }));
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
      .x(d => x((d as any).Date))
      .y(d => y((d as any).NUM))
              
      // Define the length of line
      const l = (line(this.regressionInterventionalDaysPol)).length + 10;

      var pathInt = svg.append("path")
      .datum(this.regressionInterventionalDaysPol)
      .attr("fill", "none")
      .attr("stroke", "#cc0099")
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line) 
      .transition()
      .duration(1009000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);
      // Define the div for the tooltip
      var div = d3.select("body").append("div")
        .attr("class", "tooltip")
        .style("opacity", 0);

      var pathObs = svg.append("path")
      .datum(this.regressionObservationalDaysPol)
      .attr("fill", "none")
      .attr("stroke", "#6495ED")
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line) 
      .transition()
      .duration(1009000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);

      var pathExp = svg.append("path")
      .datum(this.regressionExpandedAccessDaysPol)
      .attr("fill", "none")
      .attr("stroke", "#6600cc")
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line) 
      .transition()
      .duration(1009000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);
      // Define the div for the tooltip
      var div = d3.select("body").append("div")
        .attr("class", "tooltip")
        .style("opacity", 0);

    ////////////////TITLES/////////////////

    svg.append("text")
    .attr("x", (margin))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("Regression by") 
    .style('fill', '#0000ff');

    svg.append("circle")
    .attr("cx", margin + 69)
    .attr("cy", -24)
    .attr("r", 5)
    .attr("stroke", "white")
    .attr("fill", "#6600cc") 
    .on("click", () => this.createYearChartR())
    .on("mouseover", function (d) {
      d3.select(this)
      .style("cursor", "pointer")
      .attr("fill", "white")
      .attr("stroke", "#6600cc");
    })
    .on("mouseout", function (d) {
      d3.select(this)
      .style("cursor", "default")
      .attr("fill", "#6600cc")
      .attr("stroke", "white");
    });

    svg.append("text")
    .attr("x", (margin + 100))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("years") 
    .style('fill', '#0000ff');

    svg.append("circle")
    .attr("cx", margin + 132)
    .attr("cy", -24)
    .attr("r", 5)
    .attr("stroke", "white")
    .attr("fill", "#6495ED") 
    .on("click", () => this.createMonthChartR())
    .on("mouseover", function (d) {
      d3.select(this)
      .style("cursor", "pointer")
      .attr("fill", "white")
      .attr("stroke", "#6495ED");
    })
    .on("mouseout", function (d) {
      d3.select(this)
      .style("cursor", "default")
      .attr("fill", "#6495ED")
      .attr("stroke", "white");
    });

    svg.append("text")
    .attr("x", (margin + 171))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("months") 
    .style('fill', '#0000ff');
    

    svg.append("circle")
    .attr("cx", margin + 211)
    .attr("cy", -24)
    .attr("r", 5)
    .attr("stroke", "white")
    .attr("fill", "#3718a7") 
    .on("mouseover", function (d) {
      d3.select(this)
      .style("cursor", "pointer")
      .attr("fill", "white")
      .attr("stroke", "#3718a7");
    })
    .on("mouseout", function (d) {
      d3.select(this)
      .style("cursor", "default")
      .attr("fill", "#3718a7")
      .attr("stroke", "white");
    });

    svg.append("text")
    .attr("x", (margin + 253))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("quarters") 
    .style('fill', '#0000ff');

    /////////////////////////////////////
    
    this.regressionInterventionalDaysPol.forEach(element => {
      element.NUM = parseFloat(element.NUM).toFixed(2);
    });

    this.regressionObservationalDaysPol.forEach(element => {
      element.NUM = parseFloat(element.NUM).toFixed(2);
    });

    this.regressionExpandedAccessDaysPol.forEach(element => {
      element.NUM = parseFloat(element.NUM).toFixed(2);
    });

    svg.append("text")
    .attr("text-anchor", "end")
    .text("Date")    
    .style('fill', '#0000ff')
    .attr("text-anchor", "start")
    .attr("transform",
          "translate(" + (width/2) + " ," + 
                  (height + margin + 30) + ")")
  
    
    svg.append("circle")
    .attr("cx", margin + 298)
    .attr("cy", -24)
    .attr("r", 5)
    .attr("stroke", "white")
    .attr("fill", "#295ad9") 
    .on("mouseover", function (d) {
      d3.select(this)
      .style("cursor", "pointer")
      .attr("fill", "white")
      .attr("stroke", "#295ad9");
    })
    .on("mouseout", function (d) {
      d3.select(this)
      .style("cursor", "default")
      .attr("fill", "#295ad9")
      .attr("stroke", "white");
    });

    svg.append("text")
    .attr("x", (margin + 327))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("days") 
    .style('fill', '#0000ff');

    /////////////////////////////////////
    svg.append("text")
    .attr("text-anchor", "end")
    .text("Date")    
    .style('fill', '#0000ff')
    .attr("text-anchor", "start")
    .attr("transform",
          "translate(" + (width/2) + " ," + 
                  (height + margin + 30) + ")")
     
    
    svg.append("g")
    .style("fill","none")
    .style("stroke","none")
    .selectAll("circle")
    .data(this.regressionInterventionalDaysPol)
    .join("circle")
    .attr("cx", d => x((d as any).Date))
    .attr("cy", d => y(d.NUM))
    .attr("r", 15.5)
    .style("pointer-events","all")
    .on("mouseover", function (d) {
      d3.select(this)
        .style("cursor", "pointer")
      div.transition()
        .duration(200)
        .style("opacity", .9);
      div.html("Number of interventional trials: " + d.target.__data__.NUM + "<br/>" + "Date: " + d.target.__data__.Day)
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
      div.transition()
        .duration(500)
        .style("opacity", 0);
    });

    /////////////////////////////////////
    svg.append("g")
    .style("fill","none")
    .style("stroke","none")
    .selectAll("circle")
    .data(this.regressionObservationalDaysPol)
    .join("circle")
    .attr("cx", d => x((d as any).Date))
    .attr("cy", d => y(d.NUM))
    .attr("r", 15.5)
    .style("pointer-events","all")
    .on("mouseover", function (d) {
      d3.select(this)
        .style("cursor", "pointer")
      div.transition()
        .duration(200)
        .style("opacity", .9);
      div.html("Number of interventional trials: " + d.target.__data__.NUM + "<br/>" + "Date: " + d.target.__data__.Day)
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
      div.transition()
        .duration(500)
        .style("opacity", 0);
    });

    /////////////////////////////////////
    svg.append("g")
    .style("fill","none")
    .style("stroke","none")
    .selectAll("circle")
    .data(this.regressionExpandedAccessDaysPol)
    .join("circle")
    .attr("cx", d => x((d as any).Date))
    .attr("cy", d => y(d.NUM))
    .attr("r", 15.5)
    .style("pointer-events","all")
    .on("mouseover", function (d) {
      d3.select(this)
        .style("cursor", "pointer")
      div.transition()
        .duration(200)
        .style("opacity", .9);
      div.html("Number of interventional trials: " + d.target.__data__.NUM + "<br/>" + "Date: " + d.target.__data__.Day)
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
      div.transition()
        .duration(500)
        .style("opacity", 0);
    });
      
  }

  private drawLine(x: any, y: any, svg: any, data: any[], color: string){
    var line = d3.line()
    .curve(d3.curveCatmullRom)
    .x(d => x((d as any).Date))
    .y(d => y((d as any).NUM))
            
    // Define the length of line
    const l = (line(this.regressionInterventionalYearsPol)).length ;

    var path = svg.append("path")
      .datum(data)
      .attr("fill", "none")
      .attr("stroke", color)
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line) 
      .transition()
      .duration(9000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);
      // Define the div for the tooltip
      var div = d3.select("body").append("div")
        .attr("class", "tooltip")
        .style("opacity", 0);
      return path;
  }

  private drawTooltip(x: any, y: any, svg: any, data: any[]){
    // Define the div for the tooltip
    var div = d3.select("body").append("div")
    .attr("class", "tooltip")
    .style("opacity", 0);

    svg.append("g")
      .attr("fill", "#cc0099")
      .attr("stroke", "white")
      .attr("stroke-width", 1.5)
      .selectAll("circle")
      .data(data)
      .join("circle")
      .attr("cx", d => x((d as any).Date))
      .attr("cy", d => y((d as any).NUM))
      .attr("r", 3.5)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer")
          .attr("fill", "white")
          .attr("stroke", "#cc0099");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of interventional trials: " + d.target.__data__.NUM + "<br/>" + "Year: " + d.target.__data__.Date)
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
  }
  private createYearChartR(){
    d3.select("figure#TrialsR").selectAll("svg").remove();

    let margin = 50;
    let width = 1350 - (margin * 2);
    let height = 400 - (margin * 2);

    const svg = d3.select("figure#TrialsR").append("svg")
    .attr("width", width + (margin * 2))
    .attr("height", height + (margin * 3))
    .append("g")
    .attr("transform", "translate(" + margin + "," + margin + ")")
    
    const x = d3.scaleBand()
    .range([0, width])
    .domain(this.regressionObservationalYearsPol.map(d => d.Date))
    //.padding(0.4);

    svg.append("g")    
      .attr("transform", "translate(0," + height + ")")
      .call(d3.axisBottom(x))
      .style("color", "#0000e6")
      .selectAll("text")
      //.attr("transform", "translate(-10,0)rotate(-70)")
      .style("text-anchor", "end")
      .style("font-size", "10px");

      const maxInterventional = Math.max.apply(Math, this.regressionInterventionalYearsPol.map(function(o) { return o.NUM; }));
      const minInterventional = Math.min.apply(Math, this.regressionInterventionalYearsPol.map(function(o) { return o.NUM; }));

      // Create the Y-axis band scale
      const y = d3.scaleLinear()
        .domain([minInterventional, maxInterventional])
        .range([height, 0]);

      // Draw the Y-axis on the DOM
      svg.append("g")
        .call(d3.axisLeft(y))
        .style("color", "#0000e6");
    
      var line = d3.line()
      .curve(d3.curveCatmullRom)
      .x(d => x((d as any).Date))
      .y(d => y((d as any).NUM))
              
      // Define the length of line
      const l = (line(this.regressionInterventionalYearsPol)).length + 10;

      /*var pathInt = svg.append("path")
      .datum(this.regressionInterventionalYearsPol)
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
      // Define the div for the tooltip
      var div = d3.select("body").append("div")
        .attr("class", "tooltip")
        .style("opacity", 0);*/

      var pathIntP = this.drawLine(x,y, svg, this.regressionInterventionalYearsPol, "#cc0099")
      var pathObsP = this.drawLine(x,y, svg, this.regressionObservationalYearsPol, "#6495ED")
      var pathExpP = this.drawLine(x,y, svg, this.regressionExpandedAccessYearsPol, "#6600cc")
      var pathIntL = this.drawLine(x,y, svg, this.regressionInterventionalYearsLin, "#cc0099")
      var pathObsL = this.drawLine(x,y, svg, this.regressionObservationalYearsLin, "#6495ED")
      var pathExpL = this.drawLine(x,y, svg, this.regressionExpandedAccessYearsLin, "#6600cc")

      /*var pathObs = svg.append("path")
      .datum(this.regressionObservationalYearsPol)
      .attr("fill", "none")
      .attr("stroke", "#6495ED")
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line) 
      .transition()
      .duration(9000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);

      var pathExp = svg.append("path")
      .datum(this.regressionExpandedAccessYearsPol)
      .attr("fill", "none")
      .attr("stroke", "#6600cc")
      .attr("stroke-width", 2)
      .attr("stroke-linejoin", "round")
      .attr("stroke-linecap", "round")
      .attr("stroke-dasharray", `0,${l}`)
      .attr("d", line) 
      .transition()
      .duration(9000)
      .ease(d3.easeLinear)
      .attr("stroke-dasharray", `${l},${l}`);*/

      // Define the div for the tooltip
      var div = d3.select("body").append("div")
        .attr("class", "tooltip")
        .style("opacity", 0);
      /////////////////////////////////////

      this.regressionInterventionalYearsPol.forEach(element => {
        element.NUM = parseFloat(element.NUM).toFixed(2);
      });

      this.regressionObservationalYearsPol.forEach(element => {
        element.NUM = parseFloat(element.NUM).toFixed(2);
      });

      this.regressionExpandedAccessYearsPol.forEach(element => {
        element.NUM = parseFloat(element.NUM).toFixed(2);
      });
      /*
      svg.append("g")
      .attr("fill", "#cc0099")
      .attr("stroke", "white")
      .attr("stroke-width", 1.5)
      .selectAll("circle")
      .data(this.regressionInterventionalYearsPol)
      .join("circle")
      .attr("cx", d => x((d as any).Date))
      .attr("cy", d => y((d as any).NUM))
      .attr("r", 3.5)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer")
          .attr("fill", "white")
          .attr("stroke", "#cc0099");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of interventional trials: " + d.target.__data__.NUM + "<br/>" + "Year: " + d.target.__data__.Date)
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
      */
      this.drawTooltip(x, y, svg, this.regressionExpandedAccessYearsPol)
      this.drawTooltip(x, y, svg, this.regressionInterventionalYearsPol)
      this.drawTooltip(x, y, svg, this.regressionObservationalYearsPol)
      /////////////////////////////////////

      /*svg.append("g")
      .attr("fill", "#6495ED")
      .attr("stroke", "white")
      .attr("stroke-width", 1.5)
      .selectAll("circle")
      .data(this.regressionObservationalYearsPol)
      .join("circle")
      .attr("cx", d => x((d as any).Date))
      .attr("cy", d => y((d as any).NUM))
      .attr("r", 3.5)
      .on("mouseover", function (d) {
        d3.select(this)
          .style("cursor", "pointer")
          .attr("fill", "white")
          .attr("stroke", "#6495ED");
        div.transition()
          .duration(200)
          .style("opacity", .9);
        div.html("Number of observational trials: " + d.target.__data__.NUM + "<br/>" + "Year: " + d.target.__data__.Date)
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
      });*/

     /////////////////////////////////////

     /*svg.append("g")
     .attr("fill", "#6600cc")
     .attr("stroke", "white")
     .attr("stroke-width", 1.5)
     .selectAll("circle")
     .data(this.regressionExpandedAccessYearsPol)
     .join("circle")
     .attr("cx", d => x((d as any).Date))
     .attr("cy", d => y((d as any).NUM))
     .attr("r", 3.5)
     .on("mouseover", function (d) {
       d3.select(this)
         .style("cursor", "pointer")
         .attr("fill", "white")
         .attr("stroke", "#6600cc");
       div.transition()
         .duration(200)
         .style("opacity", .9);
       div.html("Number of trials with expanded access: " + d.target.__data__.NUM + "<br/>" + "Year: " + d.target.__data__.Date)
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
     });*/

    ////////////////TITLES/////////////////

    svg.append("text")
    .attr("x", (margin))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("Regression by") 
    .style('fill', '#0000ff');

    svg.append("circle")
    .attr("cx", margin + 69)
    .attr("cy", -24)
    .attr("r", 5)
    .attr("stroke", "white")
    .attr("fill", "#6600cc") 
    .on("mouseover", function (d) {
      d3.select(this)
      .style("cursor", "pointer")
      .attr("fill", "white")
      .attr("stroke", "#6600cc");
    })
    .on("mouseout", function (d) {
      d3.select(this)
      .style("cursor", "default")
      .attr("fill", "#6600cc")
      .attr("stroke", "white");
    });

    svg.append("text")
    .attr("x", (margin + 100))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("years") 
    .style('fill', '#0000ff');

    svg.append("circle")
    .attr("cx", margin + 132)
    .attr("cy", -24)
    .attr("r", 5)
    .attr("stroke", "white")
    .attr("fill", "#6495ED") 
    .on("click", () => this.createMonthChartR())
    .on("mouseover", function (d) {
      d3.select(this)
      .style("cursor", "pointer")
      .attr("fill", "white")
      .attr("stroke", "#6495ED");
    })
    .on("mouseout", function (d) {
      d3.select(this)
      .style("cursor", "default")
      .attr("fill", "#6495ED")
      .attr("stroke", "white");
    });

    svg.append("text")
    .attr("x", (margin + 171))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("months") 
    .style('fill', '#0000ff');
    

    svg.append("circle")
    .attr("cx", margin + 211)
    .attr("cy", -24)
    .attr("r", 5)
    .attr("stroke", "white")
    .attr("fill", "#3718a7") 
    .on("mouseover", function (d) {
      d3.select(this)
      .style("cursor", "pointer")
      .attr("fill", "white")
      .attr("stroke", "#3718a7");
    })
    .on("mouseout", function (d) {
      d3.select(this)
      .style("cursor", "default")
      .attr("fill", "#3718a7")
      .attr("stroke", "white");
    });

    svg.append("text")
    .attr("x", (margin + 253))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("quarters") 
    .style('fill', '#0000ff');

    /////////////////////////////////////
    svg.append("text")
    .attr("text-anchor", "end")
    .text("Date")    
    .style('fill', '#0000ff')
    .attr("text-anchor", "start")
    .attr("transform",
          "translate(" + (width/2) + " ," + 
                  (height + margin + 30) + ")")
  
    
    svg.append("circle")
    .attr("cx", margin + 298)
    .attr("cy", -24)
    .attr("r", 5)
    .attr("stroke", "white")
    .attr("fill", "#295ad9") 
    .on("click", () => this.createDayChartR())
    .on("mouseover", function (d) {
      d3.select(this)
      .style("cursor", "pointer")
      .attr("fill", "white")
      .attr("stroke", "#295ad9");
    })
    .on("mouseout", function (d) {
      d3.select(this)
      .style("cursor", "default")
      .attr("fill", "#295ad9")
      .attr("stroke", "white");
    });

    svg.append("text")
    .attr("x", (margin + 327))             
    .attr("y", -20 )
    .attr("text-anchor", "middle") 
    .style("font-size", "16px") 
    .style("font-weight", "bold")  
    .text("days") 
    .style('fill', '#0000ff');

    /////////////////////////////////////
    svg.append("text")
    .attr("text-anchor", "end")
    .text("Date")    
    .style('fill', '#0000ff')
    .attr("text-anchor", "start")
    .attr("transform",
          "translate(" + (width/2) + " ," + 
                  (height + margin + 30) + ")")
     
    ///////////////
    const labelInt = svg.append("g")
    .attr("font-family", "sans-serif")
    .attr("font-size", 10)
    .selectAll("g")
    .data(this.regressionInterventionalYearsPol)
    .join("g")
    .attr("transform", d => `translate(${x((d as any).Date)},${y((d as any).NUM)-15})`)
    .attr("opacity", 0)
    .on("mouseover", function (d) {
      d3.select(this)
        .style("cursor", "pointer");
      div.transition()
        .duration(200)
        .style("opacity", .9);
      div.html("Number of trials: " + d.target.__data__.NUM + "<br/>" + "Year: " + d.target.__data__.Date)
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

    labelInt.append("text")
    .text(d => (d as any).NUM)
    .call(() => this.halo);

    labelInt.transition()
      .delay((d, i) => (line((this.regressionInterventionalYearsPol as any).slice(0, i + 1))).length / l * (5000 - 125))
      .attr("opacity", 1);

    ///////////////

    const labelObs = svg.append("g")
    .attr("font-family", "sans-serif")
    .attr("font-size", 10)
    .selectAll("g")
    .data(this.regressionObservationalYearsPol)
    .join("g")
    .attr("transform", d => `translate(${x((d as any).Date)},${y((d as any).NUM)-10})`)
    .attr("opacity", 0)
    .on("mouseover", function (d) {
      d3.select(this)
        .style("cursor", "pointer");
      div.transition()
        .duration(200)
        .style("opacity", .9);
      div.html("Number of trials: " + d.target.__data__.NUM + "<br/>" + "Year: " + d.target.__data__.Date)
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
  .text(d => (d as any).NUM)
  .call(() => this.halo);

  labelObs.transition()
    .delay((d, i) => (line((this.regressionObservationalYearsPol as any).slice(0, i + 1))).length / l * (5000 - 125))
    .attr("opacity", 1);

  ///////////////

  const labelEA = svg.append("g")
  .attr("font-family", "sans-serif")
  .attr("font-size", 10)
  .selectAll("g")
  .data(this.regressionExpandedAccessYearsPol)
  .join("g")
  .attr("transform", d => `translate(${x((d as any).Date)},${y((d as any).NUM)-5})`)
  .attr("opacity", 0)
  .on("mouseover", function (d) {
    d3.select(this)
      .style("cursor", "pointer");
    div.transition()
      .duration(200)
      .style("opacity", .9);
    div.html("Number of trials: " + d.target.__data__.NUM + "<br/>" + "Year: " + d.target.__data__.Date)
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

    labelEA.append("text")
    .text(d => (d as any).NUM)
    .call(() => this.halo);

    labelEA.transition()
      .delay((d, i) => (line((this.regressionExpandedAccessYearsPol as any).slice(0, i + 1))).length / l * (5000 - 125))
      .attr("opacity", 1);
  }

  private getRegressionYears(){
    if(this.regressionObservationalYearsPol.length === 0)
      this._statisticsService.makeRegression().subscribe(response => {
        this._statisticsService.getRegressionCsv("regressionObservationalYearsPol").subscribe(dataOP => {
          this.regressionObservationalYearsPol = dataOP;
          this._statisticsService.getRegressionCsv("regressionObservationalYearsLin").subscribe(dataOL => {
            this.regressionObservationalYearsLin = dataOL;
          });
          this._statisticsService.getRegressionCsv("regressionInterventionalYearsPol").subscribe(dataIP => {
            this.regressionInterventionalYearsPol = dataIP;
            this._statisticsService.getRegressionCsv("regressionInterventionalYearsLin").subscribe(dataIL => {
              this.regressionInterventionalYearsLin = dataIL;
            });
            this._statisticsService.getRegressionCsv("regressionExpandedAccessYearsPol").subscribe(dataEAP => {
              this.regressionExpandedAccessYearsPol = dataEAP;
              this._statisticsService.getRegressionCsv("regressionExpandedAccessYearsLin").subscribe(dataEAL => {
                this.regressionExpandedAccessYearsLin = dataEAL;
                this.createYearChartR();
              });

              //////////// GET MONTHS /////////////////////
              if(this.regressionObservationalMonthsPol.length === 0)
                this.getRegressionMonths();
            

              //////////// GET DAYS /////////////////////
              if(this.regressionObservationalDaysPol.length === 0)
                this.getRegressionDays();
          
          });
        });
      });
    })
  }

  private createDayChart(){
    d3.csv("../assets/studydays.csv").then(function(data) {
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

      const x = d3.scaleTime()
        .range([0, width])
        .domain([d3.min(data, (d) => new Date((data[0] as any).Year)), 
        d3.max(data, (d) => new Date((data[data.length-1] as any).Year))]);

      const xAxis = d3.axisBottom(x)
        .ticks(width / 80).tickSizeOuter(0)

      var gX = svg.append("g")    
        .attr("transform", "translate(" + margin + "," + height + ")")
        .call(xAxis)
        .style("color", "#0000e6")
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
