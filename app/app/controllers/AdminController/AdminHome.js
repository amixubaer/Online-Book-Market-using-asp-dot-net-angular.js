app.controller("AdminHome",function($scope,$http,ajax,$routeParams){
    ajax.get("api/Admin/AllBooks",success,error);
    function success(response){
      $scope.AllBooks=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error){
      $scope.test="error";
    }
    
});