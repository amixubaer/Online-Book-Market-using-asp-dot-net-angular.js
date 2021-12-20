app.controller("EmployeeShowStatement",function($scope,$http,ajax){
    ajax.get("api/Employee/AllStatements",success,error);
    function success(response){
      $scope.Statements=response.data;
      
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
              pdfMake.createPdf(docDefinition).download("Statement.pdf");
          }
      });
    }   

});
