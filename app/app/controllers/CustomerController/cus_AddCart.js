app.controller("cus_AddCart",function($scope,$http,ajax,$routeParams, $location){
    ajax.get("api/Customer/OneBook/"+$routeParams.id ,success,error);
    function success(response){

        console.log(response.data);
        let products = [];
        response.data.Quantity = 1;
        products.push(response.data);

        var prev =localStorage.getItem("cart");

        if(prev == null)
        {
            localStorage.setItem("cart", JSON.stringify(products));
        }
        else
        {
            prevS = JSON.parse(prev);

            for(var c in prevS)
            {
                if (prevS[c].Id == $routeParams.id)
                {
                    prevS[c].Quantity +=1;
                    localStorage.setItem("cart", JSON.stringify(prevS));
                    break;
                }
                else if(prevS[c].Id != $routeParams.id)
                    localStorage.setItem("cart", JSON.stringify(prevS.concat(products)));
            }
            
        }

        console.log(localStorage.getItem("cart"));
        $location.path("/Customer/Home");
      
    }

    function error(error){
        
        
        $location.path("/Customer/Home");
        alert("Not Added to Cart");
        // console.log(response.data);
        
    }

});