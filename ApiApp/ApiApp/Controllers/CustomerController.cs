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
using System.Web.Script.Serialization;

namespace ApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CustomerController : ApiController
    {

        //Book #########################################################
        [CustomCustomerAuth]
        [Route("api/Customer/AllBooks")]
        [HttpGet]
        public List<BookModel> GetAllBooks()
        {

            return BookService.GetAll();
        }

        [CustomCustomerAuth]
        [Route("api/Customer/OneBook/{bId}")]
        [HttpGet]
        public BookModel OneBook(int bId)
        {

            return BookService.GetOne(bId);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/AddToCart/{bId}")]
        [HttpPost]
        public void AddToCart(int bId)
        {
            var uname = Request.Headers.UserAgent.ToString();
            //string uname = "cus1";
            CartService.AddToCart(bId, uname);
        }


        [CustomCustomerAuth]
        [Route("api/Customer/SrcBook")]
        [HttpGet]
        public List<BookModel> SrcBook(string src)
        {
            return BookService.SrcBook(src);
        }


        //Cart #########################################################
        [CustomCustomerAuth]
        [Route("api/Customer/Cart")]
        [HttpGet]
        public List<CartModel> GetCartByUsername()
        {
            string uname = "cus1";
            return CartService.GetCartByUsername(uname);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/PlusCart/{id}")]
        [HttpPost]
        public void PlusCart(int id)
        {
            CartService.PlusCart(id);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/MinusCart/{id}")]
        [HttpPost]
        public void MinusCart(int id)
        {
            CartService.MinusCart(id);
        }


        [CustomCustomerAuth]
        [Route("api/Customer/DeleteCart/{id}")]
        [HttpPost]
        public void DeleteCart(int id)
        {
            CartService.DeleteCart(id);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/ClearCart")]
        [HttpPost]
        public void ClearCart()
        {
            string uname = "cus1";
            CartService.ClearCart(uname);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/Checkout")]
        [HttpPost]
        public void Checkout(CheckoutModel c)
        {
            string uname = c.Uname;
            List<BookModel> od = c.Od;
            OrderService.Checkout(uname, od);
        }

        //Order ###########################################
        [CustomCustomerAuth]
        [Route("api/Customer/MyOrders")]
        [HttpGet]
        public List<OrderModel> GetMyOrders(string uname)
        {
            //string uname = "cus1";
            return OrderService.GetOrderByCustomerName(uname);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/MyCancelledOrders")]
        [HttpGet]
        public List<OrderModel> MyCancelledOrders(string uname)
        {
            //string uname = "cus1";
            return OrderService.GetCanceledOrderByCustomerName(uname);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/MyOrder/Details/{id}")]
        [HttpGet]
        public List<OrderDetailModel> GetMyOrderDetails(int id)
        {
            return OrderDetailService.GetDetail(id);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/MyOrder/Cancel/{id}")]
        [HttpPost]
        public void ReqCancel(int id)
        {
            OrderService.ReqCancel(id);
        }


        //Profile ###########################################

        [CustomCustomerAuth]
        [Route("api/Customer/Profile")]
        [HttpGet]
        public CustomerModel Profile(string uname)
        {
            //string uname = "cus1";
            return CustomerService.GetOne(uname);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/EditProfile")]
        [HttpPost]
        public void EditProfile(CustomerModel n)
        {
            CustomerService.Edit(n);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/DeleteProfile")]
        [HttpPost]
        public void DeleteProfile(CustomerModel n)
        {
            CustomerService.Delete(n);
        }



        //Singels ###########################################

        [CustomCustomerAuth]
        [Route("api/Customer/MyTransactions")]
        [HttpGet]
        public List<TransactionModel> GetMyTransactions(string uname)
        {
            //string uname = "cus1";
            return TransactionService.GetByCustomerName(uname);
        }

        [CustomCustomerAuth]
        [Route("api/Customer/AddSupport")]
        [HttpPost]
        public void AddSupport(SupportModel s)
        {
            SupportService.Add(s);
        }

        

    }
}
