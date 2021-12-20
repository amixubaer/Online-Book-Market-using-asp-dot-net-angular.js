app.controller("AdminApprovedShopList",function($scope,ajax){
    ajax.get("api/Admin/ApprovedShops",success,error);
    function success(response){
      $scope.ApprovedShopList=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error){
      $scope.test="error";
    }
});