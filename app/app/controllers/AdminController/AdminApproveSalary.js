app.controller("AdminApproveSalary",function($scope,$http,ajax,$routeParams, $location){
     
    ajax.post("api/Admin/ApproveSalary/"+$routeParams.id,success,error);
    function success(response){
      $location.path("/Admin/PendingSalary")
    }
    function error(error){
        
      $location.path("/Admin/PendingSalary")
    }
});