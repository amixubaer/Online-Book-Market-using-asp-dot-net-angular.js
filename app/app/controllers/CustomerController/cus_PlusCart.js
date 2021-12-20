app.controller("cus_PlusCart",function($routeParams, $location){

    var prev =localStorage.getItem("cart");
  
    prevS = JSON.parse(prev);

    for(var c in prevS)
    {
        if (prevS[c].Id == $routeParams.id)
        {
            prevS[c].Quantity +=1;
            localStorage.setItem("cart", JSON.stringify(prevS));
            break;
        }
        
    }

    console.log(localStorage.getItem("cart"));
    $location.path("/Customer/Cart");
    

});