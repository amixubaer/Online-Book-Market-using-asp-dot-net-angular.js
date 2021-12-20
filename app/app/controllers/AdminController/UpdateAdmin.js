app.controller("UpdateAdmin",function($scope,ajax,$location,$routeParams){

    ajax.get("api/Admin/GetOneAdmin/"+$routeParams.Username,success,error);
    function success(response){
      $scope.Id=response.data.Id;
      $scope.FirstName=response.data.FirstName;
      $scope.LastName=response.data.LastName;
      $scope.Gender=response.data.Gender;
      $scope.Dob=response.data.Dob;
      $scope.Email=response.data.Email;
      $scope.Username=response.data.Username;
      $scope.Password=response.data.Password;

      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }


    $scope.submit = function(){
        var data = {
            Id: $scope.Id,
            FirstName: $scope.FirstName,
            LastName: $scope.LastName,
            Gender: $scope.Gender,
            Dob: $scope.Dob,
            Email: $scope.Email,
            Username: $scope.Username,
            Password: $scope.Password,
        }

        ajax.post("api/Admin/EditAdmin", data, success, error)
        function success(response){
            alert("Admin Updated");
            $location.path("/Admin/AllAdmins");
        }
        function error(error){
            alert("Admin Not Updated!!!!");
            $location.path("/Admin/AllAdmins");
        }
    }
});