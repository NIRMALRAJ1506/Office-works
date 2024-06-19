import React from 'react'
import { Link, Outlet } from 'react-router-dom'

export const ReactHooksComp = () => {
    return (
        <div>
            <h2>This is React Hooks Component</h2>
            <div className='card border-primary'>
                <div className='card-header border-primary'>
                    <Link to="usestate" className='btn btn-success btn-sm'>UseState</Link>{" "}
                    <Link to="useeffect" className='btn btn-success btn-sm'>UseEffect</Link>{" "}
                </div>
                   
                
            </div>
            <Outlet></Outlet>
        </div>
    )
}
