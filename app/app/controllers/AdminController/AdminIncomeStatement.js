app.controller("AdminIncomeStatement",function($scope,ajax){
    ajax.get("api/Admin/AllStatements",success,error);
    function success(response){
      $scope.IncomeStatement=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error)
    {
      $scope.test="error";
    }

    $scope.Export = function () {
      html2canvas(document.getElementsByClassName('tblIncome'), {
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