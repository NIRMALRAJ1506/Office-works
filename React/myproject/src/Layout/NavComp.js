import React from 'react'
import { Link } from 'react-router-dom'

const NavComp = () => {
    return (
        <div>
            <Link to="slider" className='btn btn-primary btn-sm'>MySlider</Link>{" "}
            <Link to="myimages" className='btn btn-primary btn-sm'>MyImages</Link>{" "}
            <Link to="parent" className='btn btn-primary btn-sm'>Parent</Link>{" "}
            <Link to="reacthook" className='btn btn-primary btn-sm'>Hooks</Link>{" "}
        </div>
    )
}

export default NavComp
