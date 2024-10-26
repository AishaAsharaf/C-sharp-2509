function check(){
    var Number = document.getElementById("num").value
    if(Number%2 == 0){
        
        document.getElementById("result").innerHTML = "Number is even";
    }
    else if(Number%2 != 0){
       
        document.getElementById("result").innerHTML = "Number is odd";
    }
    
}