app.controller("EmployeeApprovedSalary",function($scope,ajax){
    ajax.get("api/Employee/ApprovedSalary",success,error);
    function success(response){
      $scope.AllSalary=response.data;
      console.log(data);
      $scope.test="success";
    }
    function error(error){
      $scope.test="error";
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
              pdfMake.createPdf(docDefinition).download("Salary.pdf");
          }
      });
    }   

});
