app.controller("EmployeeCancelRequest",function($scope,$http,ajax,$routeParams){

ajax.get("api/Employee/GetAllCancelRequestOrders",success,error);
    function success(response){
        $scope.route=$routeParams.id;
      $scope.EmployeeCancelRequest=response.data;
    }
    function error(error){
    }
});
    