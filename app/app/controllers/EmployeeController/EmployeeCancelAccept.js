app.controller("EmployeeCancelAccept",function($scope,$http,ajax,$routeParams, $location){
     
    ajax.post("api/Employee/CancelRequest/Approve/"+$routeParams.id,success,error);
    function success(response){
      $location.path("/Employee/CancelRequest")
    }
    function error(error){
        
      $location.path("/Employee/CancelRequest")
    }

  
});