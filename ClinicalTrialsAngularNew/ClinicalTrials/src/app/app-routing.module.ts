import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdvancedSearchComponent } from './advanced-search/advanced-search.component';
import { CustomStatisticsComponent } from './custom-statistics/custom-statistics.component';
import { SearchComponent } from './search/search.component';
import { StatisticsComponent } from './statistics/statistics.component';
import { StudyViewComponent } from './study-view/study-view.component';

const routes: Routes = [
  { path: "search",
  children: [
    {
      path: '?**',
      component: SearchComponent,
    },
  ],
  component: SearchComponent,  pathMatch: "full" },
  { path: "advanced-search", component: AdvancedSearchComponent, pathMatch: "full" },
  { path: "statistics", component: StatisticsComponent, pathMatch: "full" },
  { path: "custom-stats", component: CustomStatisticsComponent, pathMatch: "full" },
  { path: 'study/:id', component: StudyViewComponent },
  { path: "**", redirectTo: '/search' },
  { path: "", component: SearchComponent, pathMatch: "full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
