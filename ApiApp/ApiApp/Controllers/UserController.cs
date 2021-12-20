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
    public class UserController : ApiController
    {
        // Admin ###################################
        [Route("api/AllAdmins")]
        [HttpGet]
        public HttpResponseMessage GetAllAdmins()
        {
            return Request.CreateResponse(HttpStatusCode.OK, AdminService.GetAll());
        }

        [Route("api/GetOneAdmin/{uname}")]
        [HttpGet]
        public HttpResponseMessage GetOneAdmin(string uname)
        {
            return Request.CreateResponse(HttpStatusCode.OK, AdminService.GetOne(uname));
        }


        // Employee ###################################
        [Route("api/AllEmployees")]
        [HttpGet]
        public HttpResponseMessage GetAllEmployees()
        {
            return Request.CreateResponse(HttpStatusCode.OK, EmployeeService.GetAll());
        }

        [Route("api/GetOneEmployee/{uname}")]
        [HttpGet]
        public HttpResponseMessage GetOneEmployee(string uname)
        {
            return Request.CreateResponse(HttpStatusCode.OK, EmployeeService.GetOne(uname));
        }

        // Customer ###################################
        [Route("api/AllCustomers")]
        [HttpGet]
        public HttpResponseMessage GetAllCustomers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, CustomerService.GetAll());
        }

        [Route("api/GetOneCustomer/{uname}")]
        [HttpGet]
        public HttpResponseMessage GetOneCustomer(string uname)
        {
            return Request.CreateResponse(HttpStatusCode.OK, CustomerService.GetOne(uname));
        }


        // Shop ###################################
        [Route("api/AllShops")]
        [HttpGet]
        public HttpResponseMessage GetAllShops()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ShopService.GetAllShops());
        }

        [Route("api/GetOneShop/{uname}")]
        [HttpGet]
        public HttpResponseMessage GetOneShop(string uname)
        {
            return Request.CreateResponse(HttpStatusCode.OK, GetOneShop(uname));
        }


        [Route("api/Book/GetAll")]
        [HttpGet]
        public List<BookModel> GetAllBooks()
        {
            return BookService.GetAll();
        }

    }
}
