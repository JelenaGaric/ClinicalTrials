import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AgmCoreModule } from '@agm/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StatisticsComponent } from './statistics/statistics.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { StatisticsService } from './services/statistics-service';
import { HttpClientModule } from '@angular/common/http';
import { SearchComponent } from './search/search.component';
import { StudyViewComponent } from './study-view/study-view.component';
import { DndModule } from 'ngx-drag-drop';

@NgModule({
  declarations: [
    AppComponent,
    StatisticsComponent,
    SearchComponent,
    StudyViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    DndModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyBjC5xykhdXPNmyv3ffc7JXWzzrHteQlrA'
    })
  ],
  providers: [StatisticsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
