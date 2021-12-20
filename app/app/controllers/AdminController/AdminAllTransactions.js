app.controller("AdminAllTransactions",function($scope,ajax){
    ajax.get("api/Admin/AllTransactions",success,error);
    function success(response){
      $scope.AllTransactions=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error)
    {
      $scope.test="error";
    }

    $scope.Export = function () {
      html2canvas(document.getElementsByClassName('tbltrans'), {
          onrendered: function (canvas) {
              var data = canvas.toDataURL();
              var docDefinition = {
                  content: [{
                      image: data,
                      width: 500
                  }]
              };
              pdfMake.createPdf(docDefinition).download("Table.pdf");
          }
      });
    }

});