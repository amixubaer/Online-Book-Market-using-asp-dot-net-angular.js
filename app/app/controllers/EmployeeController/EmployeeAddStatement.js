app.controller("EmployeeAddStatement",function($scope,$http,ajax){

    $scope.submit = function(){
       

        var data = {
            Date: $scope.Date,
            Expenditure: $scope.Expenditure,
            Amount: $scope.Amount,
        }

        ajax.post("api/Employee/AddStatement", data, success, error)
        function success(response){
            alert("Added new statement");
        }
        function error(error){
            alert("Statement not added!!!!");
        }
    }
});
