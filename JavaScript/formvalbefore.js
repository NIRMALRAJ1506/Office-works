function checkData(){
    // window.alert("hi");
    let uid=document.getElementById("userid").value;
    if(uid.trim()===""){
        document.getElementById("iderror").innerHTML="User Id is required";
        document.getElementById("iderror").style.color="red";
    }
    else if(!uid.trim().match('^[a-zA-Z]{3,20}$')){
        document.getElementById("iderror").innerHTML="User Id must be in proper format";
        document.getElementById("iderror").style.color="red";
    }
    else{
        document.getElementById("iderror").innerHTML="";
    }

    let upass=document.getElementById("userpassword").value;
    if(upass.trim()===""){
        document.getElementById("passerror").innerHTML="User Password is required";
        document.getElementById("passerror").style.color="red";
    }
    else if(!uid.trim().match('^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$')){
        document.getElementById("passerror").innerHTML="User Password must be in proper format";
        document.getElementById("passerror").style.color="red";
    }
    else{
        document.getElementById("passerror").innerHTML="";
    }
}