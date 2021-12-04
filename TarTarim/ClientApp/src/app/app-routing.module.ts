import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetch-data/fetch-data.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:"admin",loadChildren: () => import('./admin/admin-routing/admin-routing.module').then(m=>m.AdminRoutingModule)},
  {path:"",component:HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
