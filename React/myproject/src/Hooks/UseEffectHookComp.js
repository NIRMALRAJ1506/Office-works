import { Button } from '@mui/material';
import React, { useEffect, useState } from 'react'

const UseEffectHookComp = () => {
    const [count,setCount]=useState(0);
    const[salary,setSalary]=useState(95000);
    // useEffect(()=>{
    //     setCount(count+1)
    // })

    // useFeffect(()=>{
    //     setCount(count+1)
    // },[])

    useEffect(()=>{
        setCount(count+1)
    },[salary])
    return (
        <div>
            <h2>This is Use Effect Hook Component</h2>
            <p>Counter value is : <strong>{count}</strong></p>
            <p>Salary is : <strong>{salary}</strong></p>
            <Button onClick={()=>setSalary(salary+1000)}>Counter</Button>
        </div>
    )
}

export default UseEffectHookComp
