app.controller("ShopShowTransactions",function($scope,$http,ajax){
    ajax.get("api/Shop/MyTransactions?uname="+localStorage.getItem("user"),success,error);
    function success(response){
      $scope.Transactions=response.data;
      
    }
    function error(error){
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
