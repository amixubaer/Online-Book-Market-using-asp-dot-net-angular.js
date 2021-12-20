app.controller("AdminAllAdmins",function($scope,$http,ajax,$routeParams){
  ajax.get("api/Admin/AllAdmins",success,error);
  function success(response){
    $scope.AllAdmins=response.data;
    console.log(data);
    $scope.test="success";
  }
  function error(error){
    $scope.test="error";
  }
});