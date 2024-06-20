import React, { useEffect } from 'react'
import { useState } from 'react';
import axios from 'axios';
import EditIcon from '@mui/icons-material/Edit';
import DeleteIcon from '@mui/icons-material/Delete';
import { Link } from 'react-router-dom';
import AddIcon from '@mui/icons-material/Add';
const ProductDashboard = () => {
  const[itemData,setItemData]=useState([]);
  useEffect(()=>
{
    fetchdata()
},[])

 const fetchdata=()=>{
    axios.get(`http://localhost:8888/products`).then((res) => {
       setItemData(res.data);
    }).catch((error) => { })}   
const deleterecord=(id)=>
    {
        if(window.confirm(`are You sure to delete this record wiht id:${id}`))
            {
                axios.delete(`http://localhost:8888/products/${id}`).then((res) => {
                window.alert("Record Delete Successfully");
                fetchdata();
    }).catch((error) => { })}
            }
return (
    <div>
        <h2>This is Product Dashboard Component</h2>
        <Link to='/maindash/productadd' className='btn btn-primary mb-2'>
        <AddIcon></AddIcon>Add
        </Link>
        <table className='table table-hover table-striped'>
            <thead>
                <tr>
                    <th>No</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Company</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                {
                    itemData.map((val,index) =>{
                        return <tr>
                            <td>{index+1}</td>
                            <td>{val.pname}</td>
                            <td>{val.price}</td>
                            <td>{val.company}</td>
                            <td>
                            <Link to={`/maindash/productupdate/${val.id}`} className='btn btn-outline-success'><EditIcon/></Link>
                            <button type='button' className='btn btn-outline-danger' onClick={()=>deleterecord(val.id)}><DeleteIcon/></button>
                           </td>
                        </tr>
                    })
                }
            </tbody>

        </table>
        
    </div>
)
}

export default ProductDashboard