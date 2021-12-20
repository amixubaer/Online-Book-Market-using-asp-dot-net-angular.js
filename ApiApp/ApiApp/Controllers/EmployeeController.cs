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
    public class EmployeeController : ApiController
    {

        //Order ###########################################
        [CustomEmployeeAuth]
        [Route("api/Employee/AllOrders")]
        [HttpGet]
        public List<OrderModel> GetAllOrders()
        {

            return OrderService.GetAllOrders();
        }

        [CustomEmployeeAuth]
        [Route("api/Employee/OrderDetail/{id}")]
        [HttpGet]
        public List<OrderDetailModel> GetOrderDetail(int id)
        {

            return OrderDetailService.GetDetail(id);
        }

        [CustomEmployeeAuth]
        [Route("api/Employee/GetAllCancelRequestOrders")]
        [HttpGet]
        public List<OrderModel> GetAllCancelRequestOrders()
        {

            return OrderService.GetAllCancelRequestOrders();
        }

        [CustomEmployeeAuth]
        [Route("api/Employee/CancelRequest/Approve/{id}")]
        [HttpPost]
        public void ApproveCancel(int id)
        {
            OrderService.ApproveCancel(id);
        }

        [CustomEmployeeAuth]
        [Route("api/Employee/CancelRequest/Decline/{id}")]
        [HttpPost]
        public void DeclineCancel(int id)
        {
            OrderService.DeclineCancel(id);
        }


        [CustomEmployeeAuth]
        [Route("api/Employee/AllCanceledOrders")]
        [HttpGet]
        public List<OrderModel> GetAllCanceledOrders()
        {

            return OrderService.GetAllCanceledOrders();
        }


        //Salary ###########################################
        [CustomEmployeeAuth]
        [Route("api/Employee/ApprovedSalary")]
        [HttpGet]
        public List<SalaryModel> GetApprovedSalaries()
        {

            return SalaryService.GetApproved();
        }

        [CustomEmployeeAuth]
        [Route("api/Employee/AddSalary")]
        [HttpPost]
        public void AddSalary(SalaryModel s)
        {
            SalaryService.Add(s);
        }


        //Statement ###########################################
        [CustomEmployeeAuth]
        [Route("api/Employee/AllStatements")]
        [HttpGet]
        public List<StatementModel> GetAllStatements()
        {

            return StatementService.GetAll();
        }

        [CustomEmployeeAuth]
        [Route("api/Employee/AddStatement")]
        [HttpPost]
        public void AddStatement(StatementModel s)
        {
            StatementService.Add(s);
        }


        //Transaction ###########################################
        [CustomEmployeeAuth]
        [Route("api/Employee/AllTransactions")]
        [HttpGet]
        public List<TransactionModel> GetAllTransactions()
        {

            return TransactionService.GetAll();
        }

        [CustomEmployeeAuth]
        [Route("api/Employee/AddTransaction")]
        [HttpPost]
        public void AddTransaction(TransactionModel s)
        {
            TransactionService.Add(s);
        }



        //Support ###########################################
        [CustomEmployeeAuth]
        [Route("api/Employee/AddSupport")]
        [HttpPost]
        public void AddSupport(SupportModel s)
        {
            SupportService.Add(s);
        }

        //Profile ###########################################
        [CustomEmployeeAuth]
        [Route("api/Employee/Profile")]
        [HttpGet]
        public EmployeeModel Profile(string uname)
        {
            //string uname = "emp1";
            return EmployeeService.GetOne(uname);
        }

        [CustomEmployeeAuth]
        [Route("api/Employee/EditProfile")]
        [HttpPost]
        public void EditProfile(EmployeeModel n)
        {
            EmployeeService.Edit(n);
        }
        [CustomEmployeeAuth]
        [Route("api/Employee/DeleteProfile")]
        [HttpPost]
        public void DeleteProfile(EmployeeModel n)
        {
            EmployeeService.Delete(n);
        }

    }
}
