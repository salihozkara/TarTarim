import { ProductDetailComponent } from './components/product-detail/product-detail.component';
import { LoginGuard } from './guards/login.guard';
import { ProductComponent } from './components/product/product.component';
import { QuestionsComponent } from './components/questions/questions.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetch-data/fetch-data.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:"admin",loadChildren: () => import('./admin/admin-routing/admin-routing.module').then(m=>m.AdminRoutingModule)},
  {path:"",component:HomeComponent},
  {path:"questions/:id",component:QuestionsComponent},
  {path:"products",component:ProductComponent ,canActivate:[LoginGuard]},
  {path:"productsdetail/:id",component:ProductDetailComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
