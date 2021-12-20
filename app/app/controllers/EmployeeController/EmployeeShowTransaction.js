app.controller("EmployeeShowTransaction",function($scope,$http,ajax){
    ajax.get("api/Employee/AllTransactions",success,error);
    function success(response){
      $scope.Transactions=response.data;
      
    }
    function error(error){
    }
    $scope.Export = function () {
      html2canvas(document.getElementsByClassName('tblCustomers'), {
          onrendered: function (canvas) {
              var data = canvas.toDataURL();
              var docDefinition = {
                  content: [{
                      image: data,
                      width: 500
                  }]
              };
              pdfMake.createPdf(docDefinition).download("Transaction.pdf");
          }
      });
    }   

});
