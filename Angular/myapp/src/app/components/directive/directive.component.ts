import { Component } from '@angular/core';

@Component({
  selector: 'app-directive',
  templateUrl: './directive.component.html',
  styleUrl: './directive.component.css'
})
export class DirectiveComponent {
  isCond:boolean=true;
  isCond2:boolean=false;

  cars:string[]=["BMW","Ford","Mercedes",'Porsche',"Lamborgini","Rolls Royce"];

  mycar:string="BMW";
}
