"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Person = /** @class */ (function () {
    function Person(name, contact, address, single) {
        //data-member
        this.pname = "Vijay";
        this.pcontact = 88888;
        this.paddress = "chennai";
        this.psingle = true;
        this.pname = name;
        this.pcontact = contact;
        this.paddress = address;
        this.psingle = single;
    }
    //member function
    Person.prototype.personDetails = function () {
        console.log("Name:".concat(this.pname, " Contacts:").concat(this.pcontact, " Single:").concat(this.psingle, " Address:").concat(this.paddress));
    };
    return Person;
}());
//how to create an object
// let personObj=new Person("Nirmal",99999,"Chennai",true);
// personObj.personDetails();
// let personObj1=new Person("Sandhya",101010,"Chennai",true);
// personObj1.personDetails();
// let personObj2=new Person("Malak",11111,"Chennai",true);
// personObj2.personDetails();
exports.default = Person;
