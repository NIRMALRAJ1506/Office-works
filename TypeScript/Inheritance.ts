import Person from "./oops";

class Company extends Person{
    cname:string;
    gstnumber:number;
    state:string;
    constructor(name:string,contact:number,address:string,single:boolean,compName:string,compGst:number,compState:string){
        super(name,contact,address,single);

        this.cname=compName;
        this.gstnumber=compGst;
        this.state=compState;
    }

    personDetails(){
        console.log(`Name:${this.pname}, Contact:${this.pcontact}, Single:${this.psingle},
            Address:${this.paddress} CompanyName:${this.cname}, GST Number:${this.gstnumber}, State:${this.state} Aadhar:${this.paadhar}`);
    }
}
let compObj=new Company("Vijay",888,"Chennai",true,"Changepond",12345,"Tamil Nadu");
compObj.personDetails();
