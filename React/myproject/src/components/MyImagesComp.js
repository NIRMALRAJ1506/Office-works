import React, { Component, Fragment } from 'react'
import vijay from '../Shared/Images/vijay.webp';
import ajith from '../Shared/Images/ajith.webp';
import staticData from '../Shared/Constant/Constantdata';

export class MyImagesComp extends Component {
    constructor(props) {
        super(props)
    
        this.state = {
             
        }
    }
    
    render() {
        return (
            <Fragment>
               <h2>This is My Images Component</h2> 
               <img src={vijay} alt="Naalaya Mudhalvar" height="200px" width="200px"/>
               <img src={ajith} alt="Dala Moss" height="200px" width="200px"/>
               <hr/>
               <img src={staticData.dhoni} alt="Thala Mass" height="200px" width="200px"/>
               <img src={staticData.vk} alt="EE Saala Cuppu Lolli Poppu" height="200px" width="200px"/>
               <hr/>
               <video src={staticData.vdo} alt="video" controls height="400px" width="400px"/>
               <hr/>
               <audio src={staticData.ado} alt="audio" controls/>

            </Fragment>
        )
    }
}

export default MyImagesComp
