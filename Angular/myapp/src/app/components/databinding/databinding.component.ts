import { Component } from '@angular/core';

@Component({
  selector: 'app-databinding',
  templateUrl: './databinding.component.html',
  styleUrl: './databinding.component.css'
})
export class DatabindingComponent {
  myName:string="Nirmal Raj S"
  num1:number=100;
  num2:number=200;

  greeting(){
    window.alert("Good Morning Friends");
  }

  mydata:any;
}
