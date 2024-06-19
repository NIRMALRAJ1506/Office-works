import React, { Component } from 'react'

export const HOCComp = (WrapperComp) => {
    class hoc extends Component{
        constructor(props) {
            super(props)
        
            this.state = {
                count:0
            }
        }
        
        counterInc = ()=>{
            // this.setState({count:this.state.count+1});
            this.setState((prevState)=>({count:prevState.count+1}))
        }
        
        render(){
            return  <WrapperComp count={this.state.count} counterInc={this.counterInc}></WrapperComp>
        }
    }
    return hoc
}
