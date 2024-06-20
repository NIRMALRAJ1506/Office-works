import React, { Component } from 'react'

export class VirtualDOMComp extends Component {
    constructor(props) {
        super(props)
    
        this.state = {
             breakfast:[{id:1,name:"dosa"},{id:2,name:"idly"},{id:3,name:"poori"},{id:4,name:"pongal"}]
        }
    }
    
    render() {
        return (
            <div>
                <h2>This is Virtual DOM Component</h2>
                <ul>
                    {this.state.breakfast.map((val,index)=>{
                        return <li key={index}>{val.name}</li>
                    })}
                </ul>
            </div>
        )
    }
}

export default VirtualDOMComp

