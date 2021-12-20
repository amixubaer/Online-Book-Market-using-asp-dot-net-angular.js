app.controller("cus_DeleteCart",function($routeParams, $location){

    let products2 = [];
    var prev =localStorage.getItem("cart");
  
    prevS = JSON.parse(prev);

    for(var c in prevS)
    {
        if (prevS[c].Id != $routeParams.id)
        {
            products2.push(prevS[c])
        }
        
    }

    localStorage.setItem("cart", JSON.stringify(products2));
    $location.path("/Customer/Cart");
    

});