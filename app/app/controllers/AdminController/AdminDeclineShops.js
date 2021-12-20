app.controller("AdminDeclineShops",function($scope,$http,ajax,$routeParams, $location){
     
    ajax.post("api/Admin/DeclineShop/"+$routeParams.Username,success,error);
    function success(response){
      $location.path("/Admin/PendingShops")
    }
    function error(error){
        
      $location.path("/Admin/PendingShops")
    }
});