app.controller("ShopMyOrders",function($scope,$http,ajax){
    ajax.get("api/Shop/Orders/GetByUsername?uname="+localStorage.getItem("user"),success,error);
    function success(response){
      $scope.MyOrders=response.data;
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }

});