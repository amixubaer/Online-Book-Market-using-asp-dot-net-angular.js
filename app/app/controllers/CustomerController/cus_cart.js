app.controller("cus_cart",function($scope,$http,ajax){
  $scope.AllCarts = JSON.parse(localStorage.getItem("cart"));

  


    // ajax.get("https://localhost:44348/api/Customer/Cart",success,error);
    // function success(response){
    //   $scope.AllCarts=response.data;
    //   $scope.test="testSuccess";
    // }
    // function error(error){
    //     $scope.test="testError";
    // }

});