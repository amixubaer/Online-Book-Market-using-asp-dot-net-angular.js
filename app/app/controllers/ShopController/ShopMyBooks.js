app.controller("ShopMyBooks",function($scope,$http,ajax,$routeParams){
    ajax.get("api/Shop/Book/GetByUsername?uname="+localStorage.getItem("user"),success,error);
    function success(response){
      $scope.MyBooks=response.data;
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }   
});