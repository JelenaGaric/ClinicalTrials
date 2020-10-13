import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { SearchService } from '../services/search-service.service';
import { SearchDTO } from '../DTO/searchDTO';
import { PagerService } from '../services/pager-service.service';
import { Router, ActivatedRoute } from '@angular/router';
import { PageDTO } from '../DTO/pageDTO';
import { Observable } from 'rxjs';
import { switchMap } from 'rxjs/operators';

export interface SearchParams {
  condition: string;
  country: string;
  sponsor: string;
  pageNumber: number;
  pageSize: number;
}

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  searchForm = new FormGroup ({
    Condition: new FormControl(''),
    Country:  new FormControl(''),
    Sponsor:  new FormControl('')
  });

  searchUri: string;
  
  //searchParams: Observable<SearchParams> = this._route.queryParams;

  pageDTO: PageDTO;

  searchDTO: SearchDTO;

  // pager object
  pager: any = {};

  // paged items
  pagedItems: any[];

  constructor( private _searchService: SearchService, 
              private _router: Router, 
              private _route: ActivatedRoute) { }

  ngOnInit() {
    // ako ima parametera u putanji.. postavi ih


    this.pagedItems = [];
    this.searchDTO = new SearchDTO();
    this.pageDTO = new PageDTO();
    this.pageDTO.pageNumber = 1;
    this.pageDTO.pageSize = 10;
  }


  setPage(page: string, firstTime:boolean) {

    if(firstTime === undefined || firstTime === false){ 
      this.searchUri = page.slice(23);
      this._searchService.search(this.searchUri).subscribe(data => {
        this.setPageDTO(data);
      });
    }
    //this.pagedItems = this.allItems;
  }

  onSubmit(){
    this.searchDTO = this.searchForm.value;
    
    let params: Partial<SearchParams> = {
      condition: this.searchDTO.Condition,
      country: this.searchDTO.Country,
      sponsor: this.searchDTO.Sponsor,
      pageNumber: this.pageDTO.pageNumber,
      pageSize: this.pageDTO.pageSize
    }
    //ng build --prod --base-href https://yourGithub-username.github.io/reponame/this.searchParams = params;
    this.searchUri = this.makeSearchUri(params);

    this._searchService.search(this.searchUri).subscribe(data => {
      this.setPageDTO(data);
      //this.setPage(this.searchUri, true);
      //alert(this.searchUri.slice(20))
     

      this._router.navigate([], {
        queryParams: params,
        queryParamsHandling: 'merge',
      });
      console.log(this.pagedItems)
    }, (error) => {
      console.log(error);
     });

  }

  makeSearchUri(params: any): string{
    return "api/StudyStructures/search?condition=" + params.condition + "&Country=" + params.country 
    + "&Sponsor=" + params.sponsor + "&pageNumber=" + params.pageNumber + "&pageSize=" + params.pageSize;
  }
  
  setPageDTO(data: any){
    this.pagedItems = data.data;
    this.pageDTO.pageNumber = data.pageNumber;
    this.pageDTO.firstPage = data.firstPage;
    this.pageDTO.lastPage = data.lastPage;
    this.pageDTO.previousPage = data.previousPage;
    this.pageDTO.nextPage = data.nextPage;
    this.pageDTO.totalPages = data.totalPages;
    this.pageDTO.totalRecords = data.totalRecords;
    console.log(data)
  }
}
