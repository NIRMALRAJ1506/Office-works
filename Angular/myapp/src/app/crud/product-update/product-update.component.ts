import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DatabaseServiceService } from '../../Shared/services/database-service.service';
import { FormGroup,FormControl,Validators } from '@angular/forms';
@Component({
  selector: 'app-product-update',
  templateUrl: './product-update.component.html',
  styleUrl: './product-update.component.css'
})
export class ProductUpdateComponent {
  id:any;
  prodData:any;
  oldData:any={
    pname:"",
    price:"",
    company:""
  };
  name:any
  price:any
  company:any
  constructor(private actRouteObj:ActivatedRoute,private dbserv:DatabaseServiceService,private routerObj:Router){}

  ngOnInit(){
    this.actRouteObj.paramMap.subscribe((para)=>{
      this.id=para.get('id');
      // console.log(this.id);
      this.dbserv.getsingleRecord("product",this.id).subscribe((res)=>{
        this.oldData={...res};
        console.log(this.oldData);
        this.name=this.oldData.pname
        this.price=this.oldData.price
        this.company=this.oldData.company
      })
    })
    this.prodData=new FormGroup({
      pname:new FormControl("",[Validators.required,Validators.pattern("^[a-zA-Z ]{3,20}$")]),
      price:new FormControl("",[Validators.required,Validators.pattern("^[0-9]+$")]),
      company:new FormControl("",[Validators.required,Validators.pattern("^[a-zA-Z ]{3,20}$")]),
    })
  }
  updateData(){console.log(this.prodData.value)

this.dbserv.updateRecord("product",this.id,this.prodData.value).subscribe((res)=>console.log(res))
window.alert("Record Updated Successfully");
this.routerObj.navigate(['Maindashboard/productdash'])




  }
  
  
  
  ;
  // addData(){
  //   this.dbserv.addRecord("product",this.prodData.value).subscribe(()=>{
  //     window.alert("Record Added Successfully");
  //     this.routerObj.navigate(['/Maindashboard/productdash']);
  //   })
  // }
  
}
