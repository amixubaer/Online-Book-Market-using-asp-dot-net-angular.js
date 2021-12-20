app.controller("EmployeeAddTransaction",function($scope,$http,ajax){

    $scope.submit = function(){
       

        var data = {
            ShopName: $scope.ShopName,
            CustomerName: $scope.CustomerName,
            Amount: $scope.Amount,
            Date: $scope.Date,
        }

        ajax.post("api/Employee/AddTransaction", data, success, error)
        function success(response){
            alert("Added new transaction");
        }
        function error(error){
            alert("Transaction not added!!!!");
        }
    }
});
