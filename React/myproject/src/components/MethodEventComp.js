import React, { Component } from "react";
class MethodEventComp extends Component{
    greeting=()=>{
        window.alert("Good Afternoon My Dear Friends");
    }
    welcome=(...std)=>{
        window.alert(`Welcome you ${std}`);
    }
    render(){
        
        return <div>
            <h2>This is Method and Event Component</h2>
            <button type="button" onClick={this.greeting}>Greeting</button>
            <button type="button" onClick={()=>this.welcome("Nirmal Raj")}>Welcome</button>
            <h2 onMouseOver={()=>this.greeting()}>Hover on me to call greeting Method</h2>
        </div>
    }
}
export default MethodEventComp;