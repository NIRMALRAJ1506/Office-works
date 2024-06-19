import React from 'react'
import staticData from '../Shared/Constant/Constantdata'
import mymodulecss from'./mymodulecss.module.css'
import './external.css'
const MycssComp=()=> {
    const txtObj={
        color:true?"green":"red",
        fontSize:!false?"20px":"30px",
        backgroundColor:!true?"pink":"lightgrey"
    }
    
    return (
        <>
            <h2 style={{color:"blue",backgroundColor:'aqua'}}>This is My css Component</h2>
            <p style={txtObj}>Alappara Starting Frandsss Onnum Panna Mudiyaadhu Frandssss</p>
            <img className='img' src={staticData.vijay} alt="vijay" /><br/>
            <img className={mymodulecss.box} src={staticData.gg} />
        </>
    )
}

export default MycssComp
