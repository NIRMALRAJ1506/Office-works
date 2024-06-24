import React, { Fragment } from 'react'
import { Link, Outlet, useNavigate } from 'react-router-dom'
import MyImagesComp from '../components/MyImagesComp'
import NavComp from './NavComp'
import FooterComp from './FooterComp'
const MaindashboardComp = () => {
    
    return (
        <Fragment className="container">
            {/* <h2>This is MainDashboard Component</h2> */}
            <div className='card border-primary'>
                <div className='card-header border-primary'>
                    <NavComp></NavComp>
                    <Link to="/" className="btn btn-danger  float-end">Sign Out</Link>
                </div>
                <div className='card-header border-primary'>card-nav
                    <Outlet></Outlet>
                    
                </div>
                <div className='card-header border-primary'>
                    <FooterComp></FooterComp>
                </div>
                
            </div>
            
        </Fragment>
    )
}

export default MaindashboardComp
