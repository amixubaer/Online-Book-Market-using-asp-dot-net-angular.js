app.controller("cus_MyCancelledOrders",function($scope,$http,ajax){
    ajax.get("api/Customer/MyCancelledOrders?uname="+localStorage.getItem("user"),success,error);
    function success(response){
      $scope.MyCancelledOrders=response.data;
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }

});