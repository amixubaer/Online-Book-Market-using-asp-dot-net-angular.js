app.controller("cus_OrderDetails",function($scope,ajax,$routeParams){
    ajax.get("api/Customer/MyOrder/Details/"+$routeParams.id,success,error);
    function success(response){
      $scope.OrderDetails=response.data;
      $scope.status = $routeParams.status;
      $scope.route = $routeParams.id;
      $scope.test="testSuccess";
    }
    function error(error){
      $scope.route = $routeParams.id;
      $scope.test="Error";
    }
  });