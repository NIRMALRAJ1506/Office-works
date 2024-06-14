import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MyServiceService {

  constructor() { }

  // breakFast:string[]=["Idli","Dosa","Chappathi","Upma","Poori","Pongal"]

  breakFast=[
    {name:"Idli", price:30, photo:"https://shwetainthekitchen.com/wp-content/uploads/2022/01/Idli.jpg"},
    {name:"Dosa", price:50, photo:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRXNRkQBAaLqrXbPH1qQncIKl6ZuusEMTndEA&s"},
    {name:"Chappathi", price:60, photo:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_1cmb8v4qS7opjTOZdpr_gFgg-JDiQxxDgw&s"},
    {name:"Upma", price:15, photo:"https://www.sharmispassions.com/wp-content/uploads/2013/07/RavaUpma2-e1659624509745.jpg"},
    {name:"poori", price:70, photo:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSc-qqq5bZfYBpkBU5StBjdCsDKH2vH6hMjTA&s"},
    {name:"Pongal", price:5, photo:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR42VtQcvzbTIjsZiRjkApTcVSMC0dKFOe_Fg&s"}
  ]
}
