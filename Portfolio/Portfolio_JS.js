'use strict'
function Copy(){
    let email=document.getElementById("email1").textContent;
    navigator.clipboard.writeText(email);
    alert("Email Copied!");
}

function submit_Form(){
    let name=document.getElementById("name").value;
    let industry=document.getElementById("industry").value;
    let email=document.getElementById("email").value;
    let phone=document.getElementById("phone").value;
    let message=document.getElementById("message").value;
    alert("Below is your information:\n\nName:"+name+"\nIndustry:"+industry+"\nEmail:"+email+"\nPhone:"+phone+"\nMessages:"+message+"\n\nThanks for contacting Me :)\nI will get back to you as soon as possible.\nThis page will be redirected to Home Page.");

}
