import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { SearchService } from '../services/search-service.service';
import { SearchDTO } from '../DTO/searchDTO';
import { PagerService } from '../services/pager-service.service';
import { Router } from '@angular/router';

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

  searchDTO: SearchDTO = new SearchDTO();

  allItems: any = [];

  // pager object
  pager: any = {};

  // paged items
  pagedItems: any[];

  constructor( private _searchService: SearchService, private _router: Router, private _pagerService: PagerService) { 

  }

  ngOnInit() {
    
  }

  showStudy(id: string){
    this._router.navigate(["study/"+id]);  
  }

  setPage(page: number) {
    // get pager object from service
    this.pager = this._pagerService.getPager(this.allItems.length, page);

    // get current page of items
    this.pagedItems = this.allItems.slice(this.pager.startIndex, this.pager.endIndex + 1);
  }

  onSubmit(){
    this.searchDTO = this.searchForm.value;

    this._searchService.search(this.searchDTO).subscribe(data => {
      this.allItems = data;
      console.log(this.allItems);
      this.setPage(1);
    }, (error) => {
      console.log(error);
     });

  }
}
