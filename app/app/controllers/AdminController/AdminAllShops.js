app.controller("AdminAllShops",function($scope,ajax){
    ajax.get("api/Admin/AllShops",success,error);
    function success(response){
      $scope.AdminAllShops=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error){
      $scope.test="error";
    }
});