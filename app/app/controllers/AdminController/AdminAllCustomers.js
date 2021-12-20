app.controller("AdminAllCustomers",function($scope,ajax){
    ajax.get("api/Admin/AllCustomers",success,error);
    function success(response){
      $scope.AllCustomers=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error){
      $scope.test="error";
    }
});