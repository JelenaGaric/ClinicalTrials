import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { SearchService } from '../services/search-service.service';
import { SearchDTO } from '../DTO/searchDTO';
import { PagerService } from '../services/pager-service.service';
import { Router } from '@angular/router';
import { PageDTO } from '../DTO/pageDTO';

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
  
  pageDTO: PageDTO;

  searchDTO: SearchDTO;

  // pager object
  pager: any = {};

  // paged items
  pagedItems: any[];

  constructor( private _searchService: SearchService, private _router: Router, private _pagerService: PagerService) { 

  }

  ngOnInit() {
    this.pagedItems = [];
    this.searchDTO = new SearchDTO();
    this.pageDTO = new PageDTO();
    this.pageDTO.pageNumber = 1;
    this.pageDTO.pageSize = 10;
  }

  showStudy(id: string){
    this._router.navigate(["study/"+id]);  
  }

  setPage(page: string, firstTime:boolean) {
    // get pager object from service
    //this.pager = this._pagerService.getPager(this.pageDTO.totalRecords, page);
    // get current page of items
    if(firstTime === undefined || firstTime === false){ 
      //this.makeSearchUri(page, this.pageDTO.pageSize);
      this.searchUri = page.slice(23);
      this._searchService.search(this.searchUri).subscribe(data => {
        this.setPageDTO(data);
      });
    }
    //this.pagedItems = this.allItems;
  }

  onSubmit(){
    this.searchDTO = this.searchForm.value;
    this.searchUri = this.makeSearchUri(1, this.pageDTO.pageSize);
    this._searchService.search(this.searchUri).subscribe(data => {
      this.setPageDTO(data);
      //this.setPage(this.searchUri, true);
      console.log(this.pagedItems)
    }, (error) => {
      console.log(error);
     });

  }

  makeSearchUri(pageNumber: number, pageSize: number): string{
    return "api/StudyStructures/search?condition=" + this.searchDTO.Condition + "&Country=" + this.searchDTO.Country 
    + "&Sponsor=" + this.searchDTO.Sponsor + "&pageNumber=" + pageNumber + "&pageSize=" + this.pageDTO.pageSize;
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
