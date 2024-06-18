import React, { Component } from "react";
class ClassComp extends Component{

    constructor(){
        super();
        this.state={
            company:"Changepond",
            salary:95000
        }
    }
    render(){
        const{company,salary}=this.state;
        const{myName,post}=this.props;
        return <div>
            <h2>This is Class Component</h2>
            {/* accessing props data */}
            <p>Name is :{this.props.myName} , Working as :{this.props.post}</p>
            <p>Name is :{myName} , Working as :{post}</p>
            {/* accessing state data */}
            <p>Company Name is : {this.state.company}, Salary is : {this.state.salary}</p>
            <p>Company Name is : {company}, Salary is : {salary}</p>
        </div>
    }
}
export default ClassComp;