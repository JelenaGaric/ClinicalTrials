import { Component, OnInit } from '@angular/core';
import { StudyService } from '../services/study-service.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-study-view',
  templateUrl: './study-view.component.html',
  styleUrls: ['./study-view.component.css']
})
export class StudyViewComponent implements OnInit {
  study: any;

  selectedId: string;

  constructor(private _studyService: StudyService, private _route: ActivatedRoute) { }

  ngOnInit() {
    this._route.params.subscribe((params) => {
      this.selectedId = params.id;
      this._studyService.get(this.selectedId)
        .subscribe( data => {
          this.study = data;
        });
    });
  }

}
