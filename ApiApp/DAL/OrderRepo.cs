using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class OrderRepo : IOrder<Order, int, string, List<Book>>
    {
        KetabKhanaFEntities db;
        public OrderRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }



        public void Checkout(string uname, List<Book> Od)
        {
            var entity = Od;
            var x = 0.0;

            foreach (var c in entity)
            {
                x += (float)c.Price * (float)c.Quantity;
            }

            Order o = new Order();
            o.Amount = x;
            o.CustomerName = uname;
            o.Status = "Ordered";

            db.Orders.Add(o);
            db.SaveChanges();

            foreach (var c in entity)
            {
                var od = new OrderDetail()
                {
                    OrderId = o.Id,
                    BookId = c.Id,
                    BookName = c.Title,
                    UnitPrice = c.Price,
                    Quantity = c.Quantity,
                    ShopName = c.ShopName,
                    Status = "Ordered"
                };
                db.OrderDetails.Add(od);
                db.SaveChanges();


                var book = (from bo in db.Books
                            where bo.Id == c.Id
                            select bo).FirstOrDefault();


                book.Quantity -= c.Quantity;
                db.SaveChanges();

            }


        }



        public List<Order> GetAllOrders()
        {
            return db.Orders.ToList();
        }


        public List<Order> GetAllCancelRequestOrders()
        {
            var entity = (from e in db.Orders
                          where e.Status == "Cancel Request"
                          select e).ToList();
            return entity;
        }


        public List<Order> GetAllCanceledOrders()
        {
            var entity = (from e in db.Orders
                          where e.Status == "Cancelled"
                          select e).ToList();
            return entity;
        }
        

       

        public List<Order> GetOrderByCustomerName(string uname)
        {
            var entity = (from e in db.Orders
                          where e.CustomerName == uname
                          &&(e.Status == "Ordered" 
                          || e.Status == "Cancel Request")
                          select e).ToList();
            return entity;
        }

        public List<Order> GetCanceledOrderByCustomerName(string uname)
        {
            var entity = (from e in db.Orders
                          where e.CustomerName == uname
                          && e.Status == "Cancelled"
                          select e).ToList();
            return entity;
        }


        public void ReqCancel(int id)
        {
            var order = (from o in db.Orders
                        where o.Id == id
                        select o).FirstOrDefault();

            order.Status = "Cancel Request";
            db.SaveChanges();
        }


        public void ApproveCancel(int id)
        {
            var order = (from o in db.Orders
                         where o.Id == id
                         select o).FirstOrDefault();

            order.Status = "Cancelled";
            db.SaveChanges();


            var details = (from e in db.OrderDetails
                               where e.OrderId == id
                               select e).ToList();

            foreach (var d in details)
            {
                d.Status = "Cancelled";
                db.SaveChanges();
            }
        }


        public void DeclineCancel(int id)
        {
            var order = (from o in db.Orders
                         where o.Id == id
                         select o).FirstOrDefault();

            order.Status = "Ordered";
            db.SaveChanges();
        }
    }
}
