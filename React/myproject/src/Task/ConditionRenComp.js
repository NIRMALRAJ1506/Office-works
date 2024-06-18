import React, { Component } from "react";
class ConditionRencomp extends Component{
    constructor(){
        super();
        this.state={
            isCondition:true,
        }
    }
    render(){
        // let msg="";
        // if(!this.state.isCondition){
        //     // return <h2>Admin Login Successful</h2>
        //     msg="Admin login Successful";
        // }
        // else{
        //     // return <h2>User Login successful</h2>
        //     msg="User Login Successful";
        // }
        //2.element as variable
        // return <h2>{msg}</h2>
        // 3.use of ternary operator
        // return this.state.isCondition ? <h2>Admin login Successful</h2> : <h2>User Login Successful</h2>
        // 4.use of short-circuit
        return this.state.isCondition && <h2>Admin Login Successful</h2>
    }
}
export default ConditionRencomp;