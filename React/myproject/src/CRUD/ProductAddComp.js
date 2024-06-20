import { Button } from '@mui/material';
import axios from 'axios';
import React, { useState } from 'react'
import { useNavigate } from 'react-router-dom';

const ProductAddComp = () => {
    const nav = useNavigate()
    const [itemData,setItemData] = useState({
        pname:"",
        price:"",
        company:""
    })

    const inputChangeHandler = (event) =>{
        const {type,name,value} = event.target;
        setItemData({...itemData,[name]:value})
    }

    const addRecord =(event) =>{
        event.preventDefault();
        axios.post(`http://localhost:8888/products/`,itemData).then((res) => {
            window.alert("Record Add Sucessfully ")
            nav('/maindash/productdash')
        }).catch((error) => {})
    }

    return (
        <div>

            <div className='row'>
                <div className='col-sm-3'></div>
                <div className='col-sm-6'></div>
                <div className='col-sm-3'></div>
            </div>

            <form onSubmit={addRecord}> 
                <label className='form-label'>  Enter Product Name : </label>
                <input type='text' name='pname' onChange={inputChangeHandler} value={itemData.pname} className='form-control' />
             
                <label className='form-label'>  Enter Product Price : </label>
                <input type='text' name='price' onChange={inputChangeHandler} value={itemData.price} className='form-control' />
            
                <label className='form-label'>  Enter Product Company : </label>
                <input type='text' name='company' onChange={inputChangeHandler} value={itemData.company} className='form-control' />

                <Button variant='outlined' className='btn btn-sm' type="submit">Add Data</Button>

            </form>
            
        </div>
    )
}

export default ProductAddComp