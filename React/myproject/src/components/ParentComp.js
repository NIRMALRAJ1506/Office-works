import React, { Component } from 'react'
import ChildComp from './ChildComp'

export class ParentComp extends Component {
    constructor(props) {
        super(props)
    
        this.state = {
            empname:"Nirmal Raj",
            empsal:95000 
        }
    }
    ChangeData=()=>{
        this.setState((prevState)=>({empsal:prevState.empsal+10000}))
    }
    render() {
        return (
            <div>
                <h2>This is parent Component</h2>
                <p>Employee Name is : <strong>{this.state.empname}</strong></p>
                <p>Employee Salary is : <strong>{this.state.empsal}</strong></p>
                <button type="button" onClick={()=>this.ChangeData()}>Change</button>
                <hr/>
                <ChildComp name={this.state.empname} salary={this.state.empsal} ChangeData={()=>this.ChangeData()}></ChildComp>
            </div>
        )
    }
}

export default ParentComp
