 class Person{
    //data-member
    pname:string="Vijay";
    pcontact:number=88888;
    paddress:string="chennai";
    psingle:boolean=true;
    protected paadhar:number=987654321;
    private pAge:number=23;

    constructor(name:string,contact:number,address:string,single:boolean){
        this.pname=name;
        this.pcontact=contact;
        this.paddress=address;
        this.psingle=single;
    }

    //member function
    personDetails(){
        console.log(`Name:${this.pname} Contacts:${this.pcontact} Single:${this.psingle} Address:${this.paddress} Age:${this.pAge}`);
    }
}

//how to create an object
// let personObj=new Person("Nirmal",99999,"Chennai",true);
// personObj.personDetails();
// let personObj1=new Person("Sandhya",101010,"Chennai",true);
// personObj1.personDetails();
// let personObj2=new Person("Malak",11111,"Chennai",true);
// personObj2.personDetails();

export default Person;