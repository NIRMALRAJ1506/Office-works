function checkAll(){
    let ufname=document.getElementById("fn").value;
    let regfname="^[a-zA-Z]{3,15}$";
    //let uedu=document.formval.edu;
    if(ufname.trim()===""){
        window.alert("this field is required");
        return false;
    }
    if(!ufname.trim().match(regfname)){
        window.alert("user name must contain only character and 3 to 15 characters");
        return false;
    }
    if(uedu[0].checked==false && uedu[1].checked==false && uedu[2].checked==false && uedu[3].checked==fasle&& uedu[4].checked==false){
        window.alert("please select your qualification");
        return false;
    }
}