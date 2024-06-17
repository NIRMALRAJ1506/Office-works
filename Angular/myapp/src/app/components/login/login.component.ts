import { Component } from '@angular/core';
import { DatabaseServiceService } from '../../Shared/services/database-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
uid:any;
upass:any;
userData:any=[];
constructor(private dbserv:DatabaseServiceService,private routerObj:Router){}
Login(){
  
  this.dbserv.getRecord("users").subscribe((res:any)=>{
    // console.log(res);
    this.userData=res;
    let data=this.userData.filter((val:any)=>{return val.uname==this.uid && val.upass==this.upass});
    if(data.length>0){
      sessionStorage.setItem("user",this.uid);
      this.routerObj.navigate(['Maindashboard']);
    }
    else{
      window.alert("Wrong Credentials Inserted");
      this.uid="";
      this.upass="";
    }
  })
}
}
