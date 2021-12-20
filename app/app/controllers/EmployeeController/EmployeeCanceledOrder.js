app.controller("EmployeeCanceledOrder",function($scope,$http,ajax){
    ajax.get("api/Employee/AllCanceledOrders",success,error);
    function success(response){
      $scope.EmployeeCanceledOrder=response.data;
      
    }
    function error(error){
    }

});
