app.controller("cus_MyOrders",function($scope,$http,ajax){
  
    ajax.get("api/Customer/MyOrders?uname="+localStorage.getItem("user"),success,error);
    function success(response){
      $scope.MyOrders=response.data;
      console.log(data);
      $scope.test="testSuccess";
    }
    function error(error){
        $scope.test="testError";
    }

    $scope.Export = function () {
      html2canvas(document.getElementsByClassName('transactions'), {
          onrendered: function (canvas) {
              var data = canvas.toDataURL();
              var docDefinition = {
                  content: [{
                      image: data,
                      width: 500
                  }]
              };
              pdfMake.createPdf(docDefinition).download("Transactions.pdf");
          }
      });
    }

});