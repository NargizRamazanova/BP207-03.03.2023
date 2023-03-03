// let name = "Elmira"

// for(let i = 0; i< name.length; i++){
//     console.log(name.charCodeAt(i))
// }


let mail = prompt("Enter your mail: ");

let reg = new RegExp("^[a-z]{3,15}@code.edu.az$");

console.log(reg.test(mail))

if(reg.test(mail)){
    alert("User logged in successfully!")
}else{
    alert("Invalid email");
}