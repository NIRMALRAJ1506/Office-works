console.log("Good Afternoon You All");


//1.number data type

let num1:number=100,num2:number=0.5,num3:number=123456;
console.log(num1,num2,num3);

//2.string
let fname:string="Nirmal Raj",lname:string="S";
console.log(fname,lname);

//3.boolean
let cond1:boolean = true,cond2:boolean=false;
console.log(cond1,cond2);

//4.array
let students:string[]=["Nirmal","Sandhya","Sindhuja","Rithika","Supraja"];
let emp:Array<string>=["Ikfan","Karthik","Vignesh"];


//5.tupple data: it allow user to store multiple type of data in array.
let product:[number,string]=[101,"Laptop"]

//6.enum data:
enum days{sun,mon,tue,wed,thus,fri,sat};
let data1=days.sun;
let data2=days.mon;
let data3=days.tue;
let data4=days.wed;
let data5=days.thus;
let data6=days.fri;
let data7=days.sat;

//7.union data:it allows user to store multiple type of data in single variable.
let items:string|number=25645;

//8.any datatype:when we dont know what type of data is going to store in variable.
let futureData:any=true;
