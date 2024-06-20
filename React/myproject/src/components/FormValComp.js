import React, { useState } from 'react'

export const FormValComp = () => {
    const [user,setUser]=useState({
        userName:"",
        userPassword:"",
        term:false
    })
    const inputChangeHolder=(event)=>{
        const{type,name,value}=event.target;
        setUser({...user,[name]:value})
    }
    const checkData=(event)=>{
        event.preventDefault();
        if(user.userName.trim()===""){
            window.alert("User Name is required");
            return false;
        }
        if(!user.userName.trim().match('^[a-zA-Z ]{3,20}$')){
            window.alert("User Name must contain only character min-3 and max-20");
            return false;
        }
        if(user.userPassword.trim()===""){
            window.alert("User Password is required");
            return false;
        }
        if(!user.userPassword.trim().match('^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$')){
            window.alert("User Password must be in correct format");
            return false;
        }
        if(!user.term===false){
            window.alert("please accept term and condition");
            return false;
        }
        window.alert(JSON.stringify(user));
    }
    return (
        <div>
            <h2>This is Form Val Component</h2>
            <form onSubmit={checkData}>
                <label>Enter User Name</label>
                <input type='text' name='userName' onChange={inputChangeHolder} value={user.userName}/><br/>
                <label>Enter User Password</label>
                <input type='text' name='userPassword' onChange={inputChangeHolder} value={user.userPassword}/><br/>
                <label>
                    <input type='checkbox' name='term' onChange={inputChangeHolder} value={user.term}/>
                    I Accept Term and Condition</label><br/>
                    <button type='submit' className='btn btn-primary mt-2'>Submit</button>
            </form>
        </div>
    )
}
