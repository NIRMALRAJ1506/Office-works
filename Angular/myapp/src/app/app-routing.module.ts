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

const routes: Routes = [
  {path:"Maindashboard",component:MainDashboardComponent,children:[
    {path:"",redirectTo:"databinding",pathMatch:"full"},
  //1.naming routing
  {path:"databinding",component:DatabindingComponent},
  {path:"directive",component:DirectiveComponent},
  {path:"breakFast",component:BreakFastComponent},
  {path:"productdash",component:ProductDashboardComponent},
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
