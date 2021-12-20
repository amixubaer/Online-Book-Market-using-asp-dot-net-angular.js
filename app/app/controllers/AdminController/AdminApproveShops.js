app.controller("AdminApproveShops",function($scope,$http,ajax,$routeParams, $location){
     
    ajax.post("api/Admin/ApproveShop/"+$routeParams.Username,success,error);
    function success(response){
      $location.path("/Admin/PendingShops")
    }
    function error(error){
        
      $location.path("/Admin/PendingShops")
    }
});