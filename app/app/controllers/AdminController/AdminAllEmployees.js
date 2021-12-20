app.controller("AdminAllEmployees",function($scope,$http,ajax,$routeParams){
    ajax.get("api/Admin/AllEmployees",success,error);
    function success(response){
      $scope.AllEmployees=response.data;
    }
    function error(error){
    }
});