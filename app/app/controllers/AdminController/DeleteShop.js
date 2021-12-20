app.controller("DeleteShop",function($scope,ajax,$location,$routeParams){

    ajax.get("api/Admin/GetOneShop/"+$routeParams.Username,success,error);
    function success(response){
      $scope.Id=response.data.Id;
      $scope.Name=response.data.Name;
      $scope.Address=response.data.Address;
      $scope.Bin=response.data.Bin;
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
            Name: $scope.Name,
            Address: $scope.Address,
            Bin: $scope.Bin,
            Email: $scope.Email,
            Username: $scope.Username,
            Password: $scope.Password,
        }

        ajax.post("api/Admin/DeleteShop", data, success, error)
        function success(response){
            alert("Shop Deleted");
            $location.path("/Admin/ApprovedShopList");
        }
        function error(error){
            alert("Shop Not Deleted!!!!");
            $location.path("/Admin/ApprovedShopList");
        }
    }
});