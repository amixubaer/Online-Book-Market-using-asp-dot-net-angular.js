using ApiApp.Auth;
using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace ApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    
    public class AdminController : ApiController
    {

        // Admin ###################################
        [CustomAdminAuth]
        [Route("api/Admin/CreateAdmin")]
        [HttpPost]
        public void AddAdmin(AdminModel n)
        {
            AdminService.Add(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/EditAdmin")]
        [HttpPost]
        public void EditAdmin(AdminModel n)
        {
            AdminService.Edit(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/DeleteAdmin")]
        [HttpPost]
        public void DeleteAdmin(AdminModel n)
        {
            AdminService.Delete(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/AllAdmins")]
        [HttpGet]
        public List<AdminModel> GetAllAdmins()
        {

            return AdminService.GetAll();
        }

        [CustomAdminAuth]
        [Route("api/Admin/GetOneAdmin/{uname}")]
        [HttpGet]
        public AdminModel GetOneAdmin(string uname)
        {
            return AdminService.GetOne(uname);
        }


        // Employee ###################################
        [CustomAdminAuth]
        [Route("api/Admin/CreateEmployee")]
        [HttpPost]
        public void AddEmployee(EmployeeModel n)
        {
            EmployeeService.Add(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/EditEmployee")]
        [HttpPost]
        public void EditEmployee(EmployeeModel n)
        {
            EmployeeService.Edit(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/DeleteEmployee")]
        [HttpPost]
        public void DeleteEmployee(EmployeeModel n)
        {
            EmployeeService.Delete(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/AllEmployees")]
        [HttpGet]
        public List<EmployeeModel> GetAllEmployees()
        {

            return EmployeeService.GetAll();
        }

        [CustomAdminAuth]
        [Route("api/Admin/GetOneEmployee/{uname}")]
        [HttpGet]
        public EmployeeModel GetOneEmployee(string uname)
        {
            return EmployeeService.GetOne(uname);
        }


        // Customer ###################################

        [CustomAdminAuth]
        [Route("api/Admin/EditCustomer")]
        [HttpPost]
        public void EditCustomer(CustomerModel n)
        {
            CustomerService.Edit(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/DeleteCustomer")]
        [HttpPost]
        public void DeleteCustomer(CustomerModel n)
        {
            CustomerService.Delete(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/AllCustomers")]
        [HttpGet]
        public List<CustomerModel> GetAllCustomers()
        {

            return CustomerService.GetAll();
        }

        [CustomAdminAuth]
        [Route("api/Admin/GetOneCustomer/{uname}")]
        [HttpGet]
        public CustomerModel GetOneCustomer(string uname)
        {
            return CustomerService.GetOne(uname);
        }




        // Shop ###################################
        [CustomAdminAuth]
        [Route("api/Admin/EditShop")]
        [HttpPost]
        public void EditShop(ShopModel n)
        {
            ShopService.Edit(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/DeleteShop")]
        [HttpPost]
        public void DeleteShop(ShopModel n)
        {
            ShopService.Delete(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/AllShops")]
        [HttpGet]
        public List<ShopModel> GetAllShops()
        {

            return ShopService.GetAllShops();
        }

        [CustomAdminAuth]
        [Route("api/Admin/GetOneShop/{uname}")]
        [HttpGet]
        public ShopModel GetOneShop(string uname)
        {
            return ShopService.GetOneShop(uname);
        }

        [CustomAdminAuth]
        [Route("api/Admin/ApproveShop/{uname}")]
        [HttpPost]
        public void ApproveShop(string uname)
        {
            ShopService.ApproveShop(uname);
        }

        [CustomAdminAuth]
        [Route("api/Admin/DeclineShop/{uname}")]
        [HttpPost]
        public void DeclineShop(string uname)
        {
            ShopService.DeclineShop(uname);
        }

        [CustomAdminAuth]
        [Route("api/Admin/ApprovedShops")]
        [HttpGet]
        public List<ShopModel> GetApprovedShop()
        {

            return ShopService.GetApprovedShop();
        }

        [CustomAdminAuth]
        [Route("api/Admin/PendingShop")]
        [HttpGet]
        public List<ShopModel> GetPendingShop()
        {

            return ShopService.GetPendingShop();
        }


        //Books #############################

        [CustomAdminAuth]
        [Route("api/Admin/AllBooks")]
        [HttpGet]
        public List<BookModel> GetAllBooks()
        {

            return BookService.GetAll();
        }


        //Salary #############################
        [CustomAdminAuth]
        [Route("api/Admin/ApprovedSalary")]
        [HttpGet]
        public List<SalaryModel> GetApprovedSalary()
        {

            return SalaryService.GetApproved();
        }

        [CustomAdminAuth]
        [Route("api/Admin/PendingSalary")]
        [HttpGet]
        public List<SalaryModel> GetPendingSalary()
        {

            return SalaryService.GetPending();
        }

        [CustomAdminAuth]
        [Route("api/Admin/ApproveSalary/{id}")]
        [HttpPost]
        public void ApproveSalary(int id)
        {
            SalaryService.Approve(id);
        }

        [CustomAdminAuth]
        [Route("api/Admin/DeclineSalary/{id}")]
        [HttpPost]
        public void DeclineSalary(int id)
        {
            SalaryService.Decline(id);
        }


        //Order ###########################################
        [CustomAdminAuth]
        [Route("api/Admin/AllOrders")]
        [HttpGet]
        public List<OrderModel> GetAllOrders()
        {

            return OrderService.GetAllOrders();
        }

        [CustomAdminAuth]
        [Route("api/Admin/OrderDetail/{id}")]
        [HttpGet]
        public List<OrderDetailModel> GetOrderDetail(int id)
        {

            return OrderDetailService.GetDetail(id);
        }


        //Singels ###########################################

        [CustomAdminAuth]
        [Route("api/Admin/AllTransactions")]
        [HttpGet]
        public List<TransactionModel> GetAllTransactions()
        {

            return TransactionService.GetAll();
        }

        [CustomAdminAuth]
        [Route("api/Admin/AllStatements")]
        [HttpGet]
        public List<StatementModel> GetAllStatements()
        {

            return StatementService.GetAll();
        }

        [CustomAdminAuth]
        [Route("api/Admin/AllSupport")]
        [HttpGet]
        public List<SupportModel> GetAllSupport()
        {

            return SupportService.GetAll();
        }

        [CustomAdminAuth]
        [Route("api/Admin/Profile")]
        [HttpGet]
        public AdminModel Profile(string uname)
        {
            //string uname = "admin1";
            return AdminService.GetOne(uname);
        }

        [CustomAdminAuth]
        [Route("api/Admin/EditProfile")]
        [HttpPost]
        public void EditProfile(AdminModel n)
        {
            AdminService.Edit(n);
        }

        [CustomAdminAuth]
        [Route("api/Admin/DeleteProfile")]
        [HttpPost]
        public void DeleteProfile(AdminModel n)
        {
            AdminService.Delete(n);
        }

    }
}
