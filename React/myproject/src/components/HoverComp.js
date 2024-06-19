import React, { Component } from 'react'
import { HOCComp } from './HOCComp';

export class HoverComp extends Component {


// constructor(props) {
//     super(props)

//     this.state = {
//         count:0
//     }
// }

// counterInc = ()=>{
//     // this.setState({count:this.state.count+1});
//     this.setState((prevState)=>({count:prevState.count+1}))
// }

    render() {
        return (
            <div>
                  <h2>This Count Value is {this.props.count}</h2>
                <h2 onMouseOver={()=>this.props.counterInc()}>Hover On me to Call the Increment Count</h2>

            </div>
        )
    }
}

export default HOCComp(HoverComp);