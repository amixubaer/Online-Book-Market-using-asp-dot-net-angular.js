app.controller("ShopProfile",function($scope,$http,ajax){

    ajax.get("api/Shop/Profile?uname="+localStorage.getItem("user"),success,error);
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
            Status: "Approved",
        }

        ajax.post("api/Shop/EditProfile", data, success, error)
        function success(response){
            alert("Profile Updated");
        }
        function error(error){
            alert("Profile Not Updated!!!!");
        }
    }
});