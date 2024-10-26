function add(){
    var number_one = document.getElementById("num1").value
    var number_two = document.getElementById("num2").value
    var result = parseInt(number_one) + parseInt(number_two)
    document.getElementById("result").innerHTML = "The sum is " + result;
}