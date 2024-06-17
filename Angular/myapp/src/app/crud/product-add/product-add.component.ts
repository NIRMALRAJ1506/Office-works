import { Component } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';
import { DatabaseServiceService } from '../../Shared/services/database-service.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrl: './product-add.component.css'
})
export class ProductAddComponent {
  proData:any;
  constructor(private dbserv:DatabaseServiceService,private routerObj:Router){

  }

  ngOnInit(){
    this.proData=new FormGroup({
      pname:new FormControl("",[Validators.required,Validators.pattern("^[a-zA-Z ]{3,20}$")]),
      price:new FormControl("",[Validators.required,Validators.pattern("^[0-9]+$")]),
      company:new FormControl("",[Validators.required,Validators.pattern("^[a-zA-Z ]{3,20}$")]),
    })
  }
  getData(){console.log(this.proData)};

  addData(){
    this.dbserv.addRecord("product",this.proData.value).subscribe(()=>{
      window.alert("Record Added Successfully");
      this.routerObj.navigate(['/Maindashboard/productdash']);
    })
  }
}
