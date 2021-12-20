app.controller("EmployeeOrderDetail",function($scope,ajax,$routeParams){
    ajax.get("api/Employee/OrderDetail/"+$routeParams.id,success,error);
    function success(response){
      $scope.EmployeeOrderDetail=response.data;
      $scope.id = $routeParams.id;
      //$scope.route = $routeParams.id;
    }
    function error(error){
    }
  });
  