app.controller("ShopRegistration",function($scope,$http,ajax,$location){

    $scope.submit = function(){
        var data = {
            Name: $scope.Name,
            Address: $scope.Address,
            Bin: $scope.Bin,
            Email: $scope.Email,
            Username: $scope.Username,
            Password: $scope.Password,
        }

        ajax.post("api/Registration/AddShop", data, success, error)
        function success(response){
            alert("Registration Complete");
            $location.path("/Ketabkhana/Login")
        }
        
        function error(error){
            alert("Registration Not Complete!!!!");
        }
    }
});

