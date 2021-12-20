var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/Home.html",
        controller: 'Home'
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })


    
    // Ketabkhana ########################################################################
    .when("/Ketabkhana/Home",{
        templateUrl : "views/pages/Home.html",
        controller: 'Home'
    })

    .when("/Ketabkhana/AboutUs",{
        templateUrl : "views/pages/AboutUs.html",
        controller: 'AboutUs'
    })

    .when("/Ketabkhana/Contact",{
        templateUrl : "views/pages/Contact.html",
        controller: 'Contact'
    })

    .when("/Ketabkhana/Login",{
        templateUrl : "views/pages/Login.html",
        controller: 'Login'
    })

    .when("/Logout",{
        templateUrl : "views/pages/Login.html",
        controller: 'Logout'
    })

    .when("/Ketabkhana/SignUp",{
        templateUrl : "views/pages/SignUp.html",
        controller: 'SignUp'
    })

    .when("/Ketabkhana/SignUp/ShopRegistration",{
        templateUrl : "views/pages/ShopRegistration.html",
        controller: 'ShopRegistration'
    })

    .when("/Ketabkhana/SignUp/CustomerRegistration",{
        templateUrl : "views/pages/CustomerRegistration.html",
        controller: 'CustomerRegistration'
    })



    //Customer ############################################


    .when("/Customer/Home", {
        templateUrl : "views/pages/Customer/Home.html",
        controller: 'cus_home'
    })
    .when("/Customer/Book/AddToCart/:id", {
        templateUrl : "views/pages/Customer/Home.html",
        controller: 'cus_AddCart'
    })


    

    .when("/Customer/Cart", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_cart'
    })
    .when("/Customer/Cart/PlusCart/:id", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_PlusCart'
    })
    .when("/Customer/Cart/MinusCart/:id", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_MinusCart'
    })
    .when("/Customer/Cart/DeleteCart/:id", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_DeleteCart'
    })
    .when("/Customer/Cart/ClearCart", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_ClearCart'
    })
    .when("/Customer/Cart/Checkout", {
        templateUrl : "views/pages/Customer/Cart.html",
        controller: 'cus_Checkout'
    })
    



    .when("/Customer/MyOrders", {
        templateUrl : "views/pages/Customer/MyOrders.html",
        controller: 'cus_MyOrders'
    })
    .when("/Customer/MyCancelledOrders", {
        templateUrl : "views/pages/Customer/MyCancelledOrders.html",
        controller: 'cus_MyCancelledOrders'
    })
    .when("/Customer/MyOrders/Details/:id", {
        templateUrl : "views/pages/Customer/OrderDetails.html",
        controller: 'cus_OrderDetails'
    })
    .when("/Customer/MyOrders/Cancel/:id", {
        templateUrl : "views/pages/Customer/MyOrders.html",
        controller: 'cus_CancelReqOrder'
    })


    

    .when("/Customer/MyTransactions", {
        templateUrl : "views/pages/Customer/MyTransactions.html",
        controller: 'cus_MyTransactions'
    })

    .when("/Customer/Support", {
        templateUrl : "views/pages/Customer/AddSupport.html",
        controller: 'cus_AddSupport'
    })

    .when("/Customer/Profile", {
        templateUrl : "views/pages/Customer/Profile.html",
        controller: 'cus_Profile'
    })
    .when("/Customer/DeleteProfile", {
        templateUrl : "views/pages/Customer/DeleteProfile.html",
        controller: 'cus_DeleteProfile'
    })



    // Employee ####################################

    .when("/Employee/AllOrders",{
        templateUrl : "views/pages/Employee/EmployeeAllOrder.html",
        controller: 'EmployeeAllOrder'
    })

    .when("/Employee/OrderDetail/:id",{
        templateUrl : "views/pages/Employee/EmployeeOrderDetail.html",
        controller: 'EmployeeOrderDetail'
    })

    .when("/Employee/CancelRequest",{
        templateUrl : "views/pages/Employee/EmployeeCancelRequest.html",
        controller: 'EmployeeCancelRequest'
    })

    .when("/Employee/AcceptOrder/:id",{
        templateUrl : "views/pages/Employee/EmployeeCancelRequest.html",
        controller: 'EmployeeCancelAccept'
    })

    .when("/Employee/DeclineOrder/:id",{
        templateUrl : "views/pages/Employee/EmployeeCancelRequest.html",
        controller: 'EmployeeCancelDecline'
    })

    .when("/Employee/CanceledOrders",{
        templateUrl : "views/pages/Employee/EmployeeCanceledOrder.html",
        controller: 'EmployeeCanceledOrder'
    })


    .when("/Employee/AddSalary",{
        templateUrl : "views/pages/Employee/EmployeeAddSalary.html",
        controller: 'EmployeeAddSalary'
    })

    .when("/Employee/ApprovedSalary",{
        templateUrl : "views/pages/Employee/EmployeeApprovedSalary.html",
        controller: 'EmployeeApprovedSalary'
    })

    .when("/Employee/AddStatement",{
        templateUrl : "views/pages/Employee/EmployeeAddStatement.html",
        controller: 'EmployeeAddStatement'
    })

    .when("/Employee/AllStatement",{
        templateUrl : "views/pages/Employee/EmployeeAllStatement.html",
        controller: 'EmployeeShowStatement'
    })

    .when("/Employee/AddTransaction",{
        templateUrl : "views/pages/Employee/EmployeeAddTransaction.html",
        controller: 'EmployeeAddTransaction'
    })

    .when("/Employee/AllTransaction",{
        templateUrl : "views/pages/Employee/EmployeeAllTransactions.html",
        controller: 'EmployeeShowTransaction'
    })

    .when("/Employee/Support",{
        templateUrl : "views/pages/Employee/EmployeeAddSupport.html",
        controller: 'EmployeeAddSupport'
    })

    .when("/Employee/Profile", {
        templateUrl : "views/pages/Employee/Profile.html",
        controller: 'EmployeeProfile'
    })
    .when("/Employee/DeleteProfile", {
        templateUrl : "views/pages/Employee/DeleteProfile.html",
        controller: 'EmployeeDeleteProfile'
    })



    // SHOP ########################################################################
    .when("/Shop/Home",{
        templateUrl : "views/pages/Shop/ShopHome.html",
        controller: 'ShopHome'
    })

    .when("/Shop/MyBooks",{
        templateUrl : "views/pages/Shop/ShopMyBooks.html",
        controller: 'ShopMyBooks'
    })

    .when("/Shop/AddBook",{
        templateUrl : "views/pages/Shop/ShopAddBook.html",
        controller: 'ShopAddBook'
    })

    .when("/Shop/MyBooks/BookEdit/:id",{
        templateUrl : "views/pages/Shop/ShopBookEdit.html",
        controller: 'ShopBookEdit'
    })

    .when("/Shop/MyBooks/BookDelete/:id",{
        templateUrl : "views/pages/Shop/ShopBookDelete.html",
        controller: 'ShopBookDelete'
    })

    .when("/Shop/MyOrders/BookDetails/:id",{
        templateUrl : "views/pages/Shop/ShopBookDetails.html",
        controller: 'ShopBookDetails'
    })

    .when("/Shop/MyOrders",{
        templateUrl : "views/pages/Shop/ShopMyOrders.html",
        controller: 'ShopMyOrders'
    })

    .when("/Shop/MyTransactions",{
        templateUrl : "views/pages/Shop/ShopAllTransactions.html",
        controller: 'ShopShowTransactions'
    })

    .when("/Shop/Support",{
        templateUrl : "views/pages/Shop/ShopAddSupport.html",
        controller: 'ShopAddSupport'
    })

    .when("/Shop/MyProfile",{
        templateUrl : "views/pages/Shop/ShopProfile.html",
        controller: 'ShopProfile'
    })

    .when("/Shop/DeleteProfile",{
        templateUrl : "views/pages/Shop/ShopProfileDelete.html",
        controller: 'ShopProfileDelete'
    })



    ////////////////////////     ADMIN    /////////////////////////////

    //Home
    .when("/Admin/Home", {
        templateUrl : "views/pages/Admin/Home.html",
        controller: 'AdminHome'
    })
    //Admin
    .when("/Admin/AllAdmins", {
        templateUrl : "views/pages/Admin/AllAdmins.html",
        controller: 'AdminAllAdmins'
    })

    .when("/Admin/AddAdmin", {
        templateUrl : "views/pages/Admin/AddAdmin.html",
        controller: 'AdminAddAdmin'
    })

    .when("/Admin/UpdateAdmin/:Username", {
        templateUrl : "views/pages/Admin/UpdateAdmin.html",
        controller: 'UpdateAdmin'
    })

    .when("/Admin/DeleteAdmin/:Username", {
        templateUrl : "views/pages/Admin/DeleteAdmin.html",
        controller: 'DeleteAdmin'
    })

    //Employee
    .when("/Admin/AllEmployees", {
        templateUrl : "views/pages/Admin/AllEmployees.html",
        controller: 'AdminAllEmployees'
    })

    .when("/Admin/AddEmployee", {
        templateUrl : "views/pages/Admin/AddEmployee.html",
        controller: 'AdminAddEmployee'
    })

    .when("/Admin/UpdateEmployee/:Username", {
        templateUrl : "views/pages/Admin/UpdateEmployee.html",
        controller: 'UpdateEmployee'
    })

    .when("/Admin/DeleteEmployee/:Username", {
        templateUrl : "views/pages/Admin/DeleteEmployee.html",
        controller: 'DeleteEmployee'
    })

    //Shop
    .when("/Admin/AllShops", {
        templateUrl : "views/pages/Admin/AllShops.html",
        controller: 'AdminAllShops'
    })

    .when("/Admin/UpdateShop/:Username", {
        templateUrl : "views/pages/Admin/UpdateShop.html",
        controller: 'UpdateShop'
    })

    .when("/Admin/DeleteShop/:Username", {
        templateUrl : "views/pages/Admin/DeleteShop.html",
        controller: 'DeleteShop'
    })

    .when("/Admin/ApprovedShopList", {
        templateUrl : "views/pages/Admin/ApprovedShopList.html",
        controller: 'AdminApprovedShopList'
    })

    .when("/Admin/PendingShops", {
        templateUrl : "views/pages/Admin/PendingShops.html",
        controller: 'AdminPendingShops'
    })

    .when("/Admin/ApproveShops/:Username", {
        templateUrl : "views/pages/Admin/PendingShops.html",
        controller: 'AdminApproveShops'
    })

    .when("/Admin/DeclineShops/:Username", {
        templateUrl : "views/pages/Admin/PendingShops.html",
        controller: 'AdminDeclineShops'
    })

    //Customer
    .when("/Admin/AllCustomers", {
        templateUrl : "views/pages/Admin/AllCustomers.html",
        controller: 'AdminAllCustomers'
    })

    .when("/Admin/UpdateCustomer/:Username", {
        templateUrl : "views/pages/Admin/UpdateCustomer.html",
        controller: 'UpdateCustomer'
    })

    .when("/Admin/DeleteCustomer/:Username", {
        templateUrl : "views/pages/Admin/DeleteCustomer.html",
        controller: 'DeleteCustomer'
    })

    //Salary
    .when("/Admin/AllSalary", {
        templateUrl : "views/pages/Admin/AllSalary.html",
        controller: 'AdminAllSalary'
    })

    .when("/Admin/PendingSalary", {
        templateUrl : "views/pages/Admin/PendingSalary.html",
        controller: 'AdminPendingSalary'
    })

    .when("/Admin/ApproveSalary/:id", {
        templateUrl : "views/pages/Admin/PendingSalary.html",
        controller: 'AdminApproveSalary'
    })

    .when("/Admin/DeclineSalary/:id", {
        templateUrl : "views/pages/Admin/PendingSalary.html",
        controller: 'AdminDeclineSalary'
    })

    //Order
    .when("/Admin/AllOrders", {
        templateUrl : "views/pages/Admin/AllOrders.html",
        controller: 'AdminAllOrders'
    })

    .when("/Admin/OrderDetail/:id", {
        templateUrl : "views/pages/Admin/OrderDetail.html",
        controller: 'AdminOrderDetail'
    })

    //Transaction
    .when("/Admin/Transactions", {
        templateUrl : "views/pages/Admin/Transactions.html",
        controller: 'AdminAllTransactions'
    })

    //Incomestatement
    .when("/Admin/IncomeStatement", {
        templateUrl : "views/pages/Admin/IncomeStatement.html",
        controller: 'AdminIncomeStatement'
    })

    //Support
    .when("/Admin/Support", {
        templateUrl : "views/pages/Admin/Support.html",
        controller: 'AdminSupport'
    })

    //Admin Profile
    .when("/Admin/Profile", {
        templateUrl : "views/pages/Admin/Profile.html",
        controller: 'AdminProfile'
    })

    .when("/Admin/DeleteProfile", {
        templateUrl : "views/pages/Admin/DeleteProfile.html",
        controller: 'AdminDeleteProfile'
    })




    //Otherwise ###########################################

    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);

app.config(function($httpProvider){
    $httpProvider.interceptors.push('interCeptor');
});