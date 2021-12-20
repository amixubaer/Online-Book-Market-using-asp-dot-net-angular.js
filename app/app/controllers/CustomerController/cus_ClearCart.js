app.controller("cus_ClearCart",function($routeParams, $location){

    localStorage.removeItem("cart");
    $location.path("/Customer/Cart");
    

});