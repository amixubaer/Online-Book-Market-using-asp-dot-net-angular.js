app.controller("AdminAllOrders",function($scope,ajax,$routeParams){
    ajax.get("api/Admin/AllOrders",success,error);
    function success(response){
      $scope.AllOrders=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error)
    {
      $scope.test="error";
    }

});