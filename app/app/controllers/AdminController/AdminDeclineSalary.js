app.controller("AdminDeclineSalary",function($scope,ajax,$routeParams, $location){
     
    ajax.post("api/Admin/DeclineSalary/"+$routeParams.id,success,error);
    function success(response){
      $location.path("/Admin/PendingSalary")
    }
    function error(error){
        
      $location.path("/Admin/PendingSalary")
    }
});