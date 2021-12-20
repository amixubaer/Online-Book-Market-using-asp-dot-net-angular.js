app.controller("AdminPendingSalary",function($scope,ajax){
    ajax.get("api/Admin/PendingSalary",success,error);
    function success(response){
      $scope.PendingSalary=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error){
      $scope.test="error";
    }
});