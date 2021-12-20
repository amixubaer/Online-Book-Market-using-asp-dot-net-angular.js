app.controller("EmployeeCancelDecline",function($scope,$http,ajax,$routeParams, $location){
   
      ajax.post("api/Employee/CancelRequest/Decline/"+$routeParams.id,success,error);
      function success(response){
        $location.path("/Employee/CancelRequest")
      }
      function error(error){
        $location.path("/Employee/CancelRequest")
      }

    
});