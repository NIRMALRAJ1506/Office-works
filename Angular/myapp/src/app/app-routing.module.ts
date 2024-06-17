import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DatabindingComponent } from './components/databinding/databinding.component';
import { DirectiveComponent } from './components/directive/directive.component';
import { PagenotfoundComponent } from './components/pagenotfound/pagenotfound.component';
import { EmpDetailsComponent } from './components/emp-details/emp-details.component';
import path from 'path';
import { AngFormComponent } from './components/ang-form/ang-form.component';
import { RtfComponent } from './components/rtf/rtf.component';
import { UtdfComponent } from './components/utdf/utdf.component';
import { MainDashboardComponent } from './components/main-dashboard/main-dashboard.component';
import { BreakFastComponent } from './components/break-fast/break-fast.component';
import { ProductDashboardComponent } from './crud/product-dashboard/product-dashboard.component';
import { ProductAddComponent } from './crud/product-add/product-add.component';
import { ProductUpdateComponent } from './crud/product-update/product-update.component';
import { AngularmatComponent } from './components/angularmat/angularmat.component';
import { LoginComponent } from './components/login/login.component';
import { authGuard } from './Shared/Guards/auth.guard';

const routes: Routes = [
  {path:"",component:LoginComponent},
  {path:"login",component:LoginComponent},
  {path:"Maindashboard",component:MainDashboardComponent, canActivate:[authGuard], children:[
    {path:"",redirectTo:"databinding",pathMatch:"full"},
  //1.naming routing
  {path:"databinding",component:DatabindingComponent},
  {path:"directive",component:DirectiveComponent},
  {path:"breakFast",component:BreakFastComponent},
  {path:"productdash",component:ProductDashboardComponent},
  {path:"productadd",component:ProductAddComponent},
  {path:"productupdate/:id",component:ProductUpdateComponent},
  {path:"angularmat",component:AngularmatComponent},
  //5.child routing
  {path:"angForm",component:AngFormComponent,children:[
    {path:"",component:RtfComponent},
    {path:"rtf",component:RtfComponent},
    {path:"utdf",component:UtdfComponent}
  ]},
  //4.parameterized routing
  {path:"emp-details",component:EmpDetailsComponent},
  ]},
  //2.default routing
  //{path:"",component:DatabindingComponent},
  //3.redirect routing
  
  //6.wildcard routing
  {path:"**",component:PagenotfoundComponent}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
