app.controller("AdminPendingShops",function($scope,ajax){
    ajax.get("api/Admin/PendingShop",success,error);
    function success(response){
      $scope.PendingShops=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error){
      $scope.test="error";
    }
});