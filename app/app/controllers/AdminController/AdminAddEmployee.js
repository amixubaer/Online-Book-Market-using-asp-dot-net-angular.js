app.controller("AdminAddEmployee",function($scope,$http,ajax){

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

        ajax.post("api/Admin/CreateEmployee", data, success, error)
        function success(response){
            alert("Employee Added");
        }
        function error(error){
            alert("Employee Not Added!!!!");
        }
    }
});
