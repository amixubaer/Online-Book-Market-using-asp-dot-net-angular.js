app.controller("CustomerRegistration",function($scope,$http,ajax, $location){

    $scope.submit = function(){
        var data = {
            FirstName: $scope.FirstName,
            LastName: $scope.LastName,
            Gender: $scope.Gender,
            Dob: $scope.Dob,
            Nid: $scope.Nid,
            Email: $scope.Email,
            Username: $scope.Username,
            Password: $scope.Password,
        }

        ajax.post("api/Registration/AddCustomer", data, success, error)
        function success(response){
            alert("Registration Complete");
            $location.path("/Ketabkhana/Login")
        }
        
        function error(error){
            alert("Registration Not Complete!!!!");
        }
    }
});

