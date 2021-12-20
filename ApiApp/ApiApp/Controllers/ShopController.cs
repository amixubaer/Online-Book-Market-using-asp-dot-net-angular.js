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
    public class ShopController : ApiController
    {

        //Book #######################################################
        [CustomShopAuth]
        [Route("api/Shop/Book/GetAll")]
        [HttpGet]
        public List<BookModel> GetAllBooks()
        {
            return BookService.GetAll();
        }

        [CustomShopAuth]
        [Route("api/Shop/Book/Add")]
        [HttpPost]
        public void Add(BookShopModel data)
        {
            string uname = data.Uname;
            BookModel b = data.book;

            b.ShopName = uname;
            BookService.Add(b);
        }

        [CustomShopAuth]
        [Route("api/Shop/Book/GetByUsername")]
        [HttpGet]
        public List<BookModel> GetByUsername(string uname)
        {
            //string uname = "shop1";
            return BookService.GetByUsername(uname);
        }

        [CustomShopAuth]
        [Route("api/Shop/OneBook/{bId}")]
        [HttpGet]
        public BookModel OneBook(int bId)
        {

            return BookService.GetOne(bId);
        }

        [CustomShopAuth]
        [Route("api/Shop/Book/Edit")]
        [HttpPost]
        public void EditBook(BookModel b)
        {
            BookService.Edit(b);
        }

        [CustomShopAuth]
        [Route("api/Shop/Book/Delete")]
        [HttpPost]
        public void DeleteBook(BookModel b)
        {
            BookService.Delete(b);
        }


        //Order (Details) #######################################################
        [CustomShopAuth]
        [Route("api/Shop/Orders/GetByUsername")]
        [HttpGet]
        public List<OrderDetailModel> GetMyOrders(string uname)
        {
            //string uname = "shop1";
            return OrderDetailService.GetByShopName(uname);
        }


        //Singels #######################################################
        [CustomShopAuth]
        [Route("api/Shop/MyTransactions")]
        [HttpGet]
        public List<TransactionModel> GetMyTransactions(string uname)
        {
            //string uname = "shop1";
            return TransactionService.GetByShopName(uname);
        }

        [CustomShopAuth]
        [Route("api/Shop/AddSupport")]
        [HttpPost]
        public void AddSupport(SupportModel s)
        {
            SupportService.Add(s);
        }


        //Profile ###########################################
        [CustomShopAuth]
        [Route("api/Shop/Profile")]
        [HttpGet]
        public ShopModel Profile(string uname)
        {
            //string uname = "shop1";
            return ShopService.GetOneShop(uname);
        }

        [CustomShopAuth]
        [Route("api/Shop/EditProfile")]
        [HttpPost]
        public void EditProfile(ShopModel n)
        {
            ShopService.Edit(n);
        }

        [CustomShopAuth]
        [Route("api/Shop/DeleteProfile")]
        [HttpPost]
        public void DeleteProfile(ShopModel n)
        {
            ShopService.Delete(n);
        }

    }
}
