import { Component } from '@angular/core';

@Component({
  selector: 'app-mypipe',
  templateUrl: './mypipe.component.html',
  styleUrl: './mypipe.component.css'
})
export class MypipeComponent {
    msg:string="Hello friend,you all are fantastic participant.";

    emp:any={
      id:100,
      name:"Nirmal",
      salary:95000
    }

    dateObj=new Date();
}
