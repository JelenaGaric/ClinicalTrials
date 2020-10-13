import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import { WelcomeComponent } from './welcome/welcome.component';
import { SearchComponent } from './search/search.component';
import { StudyViewComponent } from './study-view/study-view.component';
import { AdvancedSearchComponent } from './advanced-search/advanced-search.component';

const routes: Routes = [
    { path: "", component: WelcomeComponent, pathMatch: "full" },
    { path: "search",
    children: [
      {
        path: '?**',
        component: SearchComponent,
      },
    ],
     component: SearchComponent, 
     pathMatch: "full" },
    //{ path: "search?condition=:condition&Country=:country&Sponsor=:sponsor&pageNumber=:pageNumber&pageSize=:pageSize", component: SearchComponent},
    { path: "advanced-search", component: AdvancedSearchComponent, pathMatch: "full" },
    { path: 'study/:id', component: StudyViewComponent },
    { path: 'search/:condition/:nesto', component: SearchComponent}
    //{ path: "**", redirectTo: '/' }
];

@NgModule({  
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  })

  export class AppRoutingModule {
}