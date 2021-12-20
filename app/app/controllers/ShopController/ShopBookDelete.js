app.controller("ShopBookDelete",function($scope,$http,ajax,$routeParams,$location){

    ajax.get("api/Shop/OneBook/"+$routeParams.id,success,error);
    function success(response){
      $scope.Id=response.data.Id;
      $scope.Title=response.data.Title;
      $scope.Author=response.data.Author;
      $scope.Publisher=response.data.Publisher;
      $scope.Edition=response.data.Edition;
      $scope.Price=response.data.Price;
      $scope.Quantity=response.data.Quantity;
      $scope.ShopName=response.data.ShopName;

      $scope.test="testSuccess";
    }
    function error(error){
        $scope.route = $routeParams.id;
        $scope.test="testError";
    }


    $scope.submit = function(){
        var data = {
            Id: $scope.Id,
            Title: $scope.Title,
            Author: $scope.Author,
            Publisher: $scope.Publisher,
            Edition: $scope.Edition,
            Price: $scope.Price,
            Quantity: $scope.Quantity,
            ShopName: $scope.ShopName,
        }

        ajax.post("api/Shop/Book/Delete", data, success, error)
        function success(response){
            alert("Book Deleted");
            $location.path("/Shop/MyBooks")
        }
        function error(error){
            alert("Book Not Deleted!!!!");
            $location.path("/Shop/MyBooks")
        }
    }
});