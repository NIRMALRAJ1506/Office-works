import React, { Component } from "react";

class MyDetailsComp extends Component{
    constructor(){
        super();
        this.state={
            gender:"Male",
            maritalstatus:"Single",
            address:"Chennai"
        }
    }
    render(){
        const{fname,lname,email,contact}=this.props;
        const{gender,maritalstatus,address}=this.state;
        return <div>
            <p>My First Name is : {fname} My Last Name is : {lname} My Email is : {email} My contact is : {contact}</p>
            <p>My Gender is : {gender} My MaritalStatus is : {maritalstatus} My Address is : {address}</p>
        </div>
    }
}
export default MyDetailsComp;