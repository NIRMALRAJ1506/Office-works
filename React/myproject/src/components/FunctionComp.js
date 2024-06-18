// function FunctionComp(){
//     return <h2>This is Function Component</h2>
// }

const FunctionComp=(props)=>{
    return <div>
        <h2>This is Function Component</h2>
        <p>My Name is :{props.myName} , I am :{props.post}</p>
    </div>
}
export default FunctionComp;