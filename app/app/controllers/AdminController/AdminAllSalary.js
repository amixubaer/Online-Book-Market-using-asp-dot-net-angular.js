app.controller("AdminAllSalary",function($scope,ajax){
    ajax.get("api/Admin/ApprovedSalary",success,error);
    function success(response){
      $scope.AllSalary=response.data;
      console.log(response.data);
      $scope.test="success";
    }
    function error(error)
    {
      $scope.test="error";
    }

    $scope.Export = function () {
      html2canvas(document.getElementsByClassName('tblSalary'), {
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