app.controller("ShopHome",function($scope,$http,ajax,$routeParams){
    ajax.get("api/Shop/Book/GetAll",success,error);
    function success(response){
      $scope.AllBooks=response.data;
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }   
});