app.controller("DeleteCustomer",function($scope,$http,ajax,$location,$routeParams){

    ajax.get("api/Admin/GetOneCustomer/"+$routeParams.Username,success,error);
    function success(response){
      $scope.Id=response.data.Id;
      $scope.FirstName=response.data.FirstName;
      $scope.LastName=response.data.LastName;
      $scope.Gender=response.data.Gender;
      $scope.Dob=response.data.Dob;
      $scope.Nid=response.data.Nid;
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
            Nid: $scope.Nid,
            Email: $scope.Email,
            Username: $scope.Username,
            Password: $scope.Password,
        }

        ajax.post("api/Admin/DeleteCustomer", data, success, error)
        function success(response){
            alert("Customer Deleted");
            $location.path("/Admin/AllCustomers");
        }
        function error(error){
            alert("Customer Not Deleted!!!!");
            $location.path("/Admin/AllCustomers");
        }
    }
});