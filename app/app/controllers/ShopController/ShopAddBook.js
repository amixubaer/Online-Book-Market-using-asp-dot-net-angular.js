app.controller("ShopAddBook",function($scope,$http,ajax,$location){

    $scope.submit = function(){
        var b = {
            Id: $scope.Id,
            Title: $scope.Title,
            Author: $scope.Author,
            Publisher: $scope.Publisher,
            Edition: $scope.Edition,
            Price: $scope.Price,
            Quantity: $scope.Quantity,
        }

        var user = localStorage.getItem("user");

        var data = {
            book: b,
            Uname: user
        }

        ajax.post("api/Shop/Book/Add", data, success, error)
        function success(response){
            alert("Book Added");
            $location.path("/Shop/MyBooks")
        }
        function error(error){
            alert("Book Not Added!!!!");
            $location.path("/Shop/MyBooks")
        }
    }
});
