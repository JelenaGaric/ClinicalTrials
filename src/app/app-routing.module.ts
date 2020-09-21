import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import { WelcomeComponent } from './welcome/welcome.component';
import { SearchComponent } from './search/search.component';
import { StudyViewComponent } from './study-view/study-view.component';

const routes: Routes = [
    { path: "", component: WelcomeComponent, pathMatch: "full" },
    { path: "search", component: SearchComponent, pathMatch: "full" },
    { path: 'study/:id', component: StudyViewComponent },
    { path: "**", redirectTo: '/' }
];

@NgModule({  
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  })

  export class AppRoutingModule {
}