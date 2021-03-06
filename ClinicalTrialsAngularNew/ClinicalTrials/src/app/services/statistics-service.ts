import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { throwError, Observable } from 'rxjs';
import { catchError } from 'rxjs/operators'; 
import { GlobalVariable } from '../global';

@Injectable({
  providedIn: 'root'
})
export class StatisticsService {
  //private headerOptions = new HttpHeaders({ 'Content-Type': 'application/json' });

  private readonly statisticsUri = "api/Statistics";
  private readonly regressionUri = "api/Regression";

  constructor(private http: HttpClient) { }
  

  searchStatistics(searchDTO: any) : any {
    return this.http.post<any>(GlobalVariable.baseUrl + this.statisticsUri, searchDTO)
        .pipe(catchError(this.handleError.bind(this)));
  }

  getStats(searchDTO: any, searchUri: string) : any {
    return this.http.post<any>(GlobalVariable.baseUrl + this.statisticsUri + searchUri, searchDTO)
        .pipe(catchError(this.handleError.bind(this)));
  }

  getChart(searchUri: string) : any {
    return this.http.get<any>(GlobalVariable.baseUrl + this.statisticsUri + searchUri)
        .pipe(catchError(this.handleError.bind(this)));
  }

  makeRegression() : any {
    return this.http.get<any>(GlobalVariable.baseUrl + this.regressionUri)
        .pipe(catchError(this.handleError.bind(this)));
  }

  getRegressionCsv(type: string) : any {
    return this.http.get<any>(GlobalVariable.baseUrl + this.regressionUri + "/" + type)
        .pipe(catchError(this.handleError.bind(this)));
  }

  handleError(errorResponse: HttpErrorResponse) {
    if (errorResponse.error instanceof ErrorEvent) {
      console.error('Client Side Error :', errorResponse.error.message);
    } else {
      console.error('Server Side Error :', errorResponse);
    }

  // return an observable with a meaningful error message to the end user
  return throwError('There is a problem with the service. We are notified & working on it.Please try again later.');
  }
 
}
