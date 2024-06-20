import React, { useState,useEffect } from 'react'
import { useNavigate,useParams } from 'react-router-dom';
import axios from 'axios';



const ProductUpdateComp = () => {

    
const {id} = useParams();
        const nav = useNavigate()
        const [itemData,setItemData] = useState({
            id:"",
            pname:"",
            price:"",
            company:""
        });
    
        const inputChangeHandler = (events)=>{
            const {type,name,value} = events.target;
            setItemData({...itemData,[name]:value});
        }
    

        const addRecord = (event)=>{
            event.preventDefault();
            axios.put(`http://localhost:8888/products/${id}`,itemData).then(()=>{
                window.alert("Record Updated Successfully");
                nav('/maindash/productdash');
            }).catch((error)=>{})
        }
        

useEffect(()=>{
axios.get(`http://localhost:8888/products/${id}`).then((res)=>{
    // console.log(res.data);
    setItemData(res.data);
}).catch((error)=>{})
},[])

    return (
        <div>
            <h2>This is product Update component</h2>
            <div className='col-sm-3'>
                <div className='col-sm-6'>
                
           

            <form onSubmit={addRecord}> 
                <label className='form-label'>  Enter Product Name : </label>
                <input type='text' name='pname' onChange={inputChangeHandler} value={itemData.pname} className='form-control' />
             
                <label className='form-label'>  Enter Product Price : </label>
                <input type='text' name='price' onChange={inputChangeHandler} value={itemData.price} className='form-control' />
            
                <label className='form-label'>  Enter Product Company : </label>
                <input type='text' name='company' onChange={inputChangeHandler} value={itemData.company} className='form-control' />

                <button type='submit' className='btn btn-primary mt-2'>Update Data</button>

            </form>

            <div className='col-sm-3'>
            </div>
 </div>
            </div>
            </div>
       
    )
}

export default ProductUpdateComp