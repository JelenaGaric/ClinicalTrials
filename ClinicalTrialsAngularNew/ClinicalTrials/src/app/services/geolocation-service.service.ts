import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { throwError, Observable } from 'rxjs';
import { catchError } from 'rxjs/operators'; 
import { GlobalVariable } from '../global';
import { LocationDTO } from '../DTO/locationDTO';

@Injectable({
  providedIn: 'root'
})
export class GeolocationService {
  private headerOptions = new HttpHeaders({ 'Content-Type': 'application/json' });

  private readonly apiUri = "https://maps.googleapis.com/maps/api/geocode/json?address=";
  private readonly apiKey = ",+CA&key=AIzaSyBjC5xykhdXPNmyv3ffc7JXWzzrHteQlrA";
  
  constructor(private http: HttpClient) { }
  
  locations : any[] = [];

  getLocation(location: string) : any {
    return this.http.get<any>(this.apiUri + location + this.apiKey);
    //.pipe(catchError(this.handleError.bind(this)));
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
