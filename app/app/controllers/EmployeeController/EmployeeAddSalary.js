app.controller("EmployeeAddSalary",function($scope,$http,ajax){

    $scope.submit = function(){
       

        var data = {
            EmployeeUsername: $scope.EmployeeUsername,
            Salary1: $scope.Sal,
            Bonus: $scope.Bonus,
        }

        ajax.post("api/Employee/AddSalary", data, success, error)
        function success(response){
            alert("Requested new salary");
        }
        function error(error){
            alert("Salary not requested!!!!");
        }
    }
});
