app.controller("Home",function($scope,$http,ajax,$routeParams){
    ajax.get("api/Book/GetAll",success,error);
    function success(response){
      $scope.AllBooks=response.data;
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }   
});