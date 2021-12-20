app.controller("EmployeeAllOrder",function($scope,$http,ajax){
    ajax.get("api/Employee/AllOrders",success,error);
    function success(response){
      $scope.EmployeeAllOrder=response.data;
    }
    function error(error){
    }

});

