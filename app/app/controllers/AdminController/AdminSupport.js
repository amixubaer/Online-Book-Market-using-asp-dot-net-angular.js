app.controller("AdminSupport",function($scope,ajax){
    ajax.get("api/Admin/AllSupport",success,error);
    function success(response){
      $scope.AllSupports=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error){
      $scope.test="error";
    }
});