import React from 'react'

export default function ChildComp(props) {
    return (
        <div>
            <h2>This is Child Component</h2>
            <h2>Employee Name is : {props.name}</h2>
            <h2>Employee Salary is : {props.salary}</h2>
            <button type="button" onClick={props.ChangeData}>Change</button>
        </div>
    )
}

