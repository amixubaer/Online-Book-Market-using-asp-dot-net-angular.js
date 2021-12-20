app.controller("cus_Checkout",function(ajax, $location){

    var o = JSON.parse(localStorage.getItem("cart"));
    var user = localStorage.getItem("user");

    var data = {
        Od: o,
        Uname: user
    }

    console.log(data);
    localStorage.removeItem("cart");


    ajax.post("Customer/Checkout", data, success, error)
        function success(response){
            console.log(response);
            alert("Order placed successfully.");
        }
        function error(error){
            alert("Order not placed !!!!");
        }



    $location.path("/Customer/Home");
    

});