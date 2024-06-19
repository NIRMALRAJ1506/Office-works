import React, { Component } from 'react'
import { HOCComp } from './HOCComp'
import { Button } from '@mui/material'

export class ClickCounterComp extends Component {
    // constructor(props) {
    //     super(props)
    
    //     this.state = {
    //          count:0,
    //     }
    // }
    // counterInc=()=>{
    //     this.setState((prevState)=>({count:prevState.count+1}))
    // }
    render() {
        return (
            <div>
                <h2>This is Click Counter Component</h2>
                <h2 className='text-danger'>Counter value is : <strong>{this.props.count}</strong></h2>
                {/* <button type="button" className='btn btn-primary' onClick={()=>this.props.counterInc()}>Click Increment Counter</button> */}
                <Button variant="contained" onClick={()=>this.props.counterInc()}>count++</Button>
            </div>
        )
    }
}

export default HOCComp(ClickCounterComp) 
