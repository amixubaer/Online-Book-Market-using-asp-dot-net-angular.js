app.controller("AdminAddAdmin",function($scope,$http,ajax){

    $scope.submit = function(){
        var data = {
            FirstName: $scope.FirstName,
            LastName: $scope.LastName,
            Gender: $scope.Gender,
            Dob: $scope.Dob,
            Email: $scope.Email,
            Username: $scope.Username,
            Password: $scope.Password,
        }

        ajax.post("api/Admin/CreateAdmin", data, success, error)
        function success(response){
            alert("Admin Added");
        }
        function error(error){
            alert("Admin Not Added!!!!");
        }
    }
});
