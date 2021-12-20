app.controller("ShopBookDetails",function($scope,ajax,$routeParams){
    ajax.get("api/Shop/OneBook/"+$routeParams.id,success,error);
    function success(response){
      console.log(response.data);
        $scope.BookDetails=response.data;
        $scope.status = $routeParams.status;
        $scope.route = $routeParams.id;
        $scope.test="Success";
    }

    function error(error){
      $scope.route = $routeParams.id;
      $scope.test="Error";
    }
  });