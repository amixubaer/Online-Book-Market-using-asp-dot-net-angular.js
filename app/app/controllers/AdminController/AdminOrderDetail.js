app.controller("AdminOrderDetail",function($scope,ajax,$routeParams){
    ajax.get("api/Admin/OrderDetail/"+$routeParams.id,success,error);
    function success(response){
      $scope.OrderDetail=response.data;
      $scope.id = $routeParams.id;
      console.log(data);
      $scope.test="success";
      //$scope.route = $routeParams.id;
    }
    function error(error)
    {
      $scope.test="error";
    }
  });