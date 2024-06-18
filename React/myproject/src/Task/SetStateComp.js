import React, { Component } from "react";
class SetStateComp extends Component{
    constructor(){
        super();
        this.state={
            fname:"Nirmal",
            count:0
        }
    }
    CounterInc=()=>{
        this.setState((prevState)=>({count:prevState.count+1}))
    }
    CounterDec=()=>{
        this.setState((prevState)=>({count:prevState.count-1}))
    }
    Fullname=()=>{
        this.setState((prevState)=>({fname:prevState.fname="Nirmal Raj"}))
    }
    render(){
        return <div>
            <h2>This is Set State Component</h2>
            <p>Count value is : <strong>{this.state.count}</strong></p>
            <p>My Name is : <strong>{this.state.fname}</strong></p>
            <button type="button" onClick={()=>{this.CounterInc()}}>Counter Increment</button>
            <button type="button" onClick={()=>{this.CounterDec()}}>Counter Decrement</button>
            <button type="button" onClick={()=>{this.Fullname()}}>FullName</button>
        </div>
    }
}
export default SetStateComp;