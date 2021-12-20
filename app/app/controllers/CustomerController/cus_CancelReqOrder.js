app.controller("cus_CancelReqOrder",function($scope, ajax,$routeParams, $location){
    ajax.post("api/Customer/MyOrder/Cancel/"+$routeParams.id,success,error);
      function success(response){
        $scope.testc="CancelCestSuccess";
        alert("Requested for cancellation");
        $location.path("/Customer/MyOrders");
      }
      function error(error){
        $scope.testc="CanceltestError";
        $location.path("/Customer/MyOrders");
      }
});