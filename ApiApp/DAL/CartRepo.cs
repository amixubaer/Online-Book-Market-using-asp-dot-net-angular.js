using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CartRepo : ICart<Cart, int, string>
    {
        KetabKhanaFEntities db;
        public CartRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }


        public void AddToCart(int src, string uname)
        {
            var dab = DataAccessFactory.BookDataAcess();
            var book = dab.GetOne(src);

            var cart = new Cart();
            cart.ShopName = book.ShopName;
            cart.BookId = book.Id;
            cart.BookName = book.Title;
            cart.UnitPrice = book.Price;
            cart.Quantity = 1;
            cart.CustomerName = uname;

            db.Carts.Add(cart);
            db.SaveChanges();       
        }

        public void ClearCart(string uname)
        {
            var entity = (from e in db.Carts
                          where e.CustomerName == uname
                          select e).ToList();
            entity.Clear();
            db.SaveChanges();
        }

        public void DeleteCart(int src)
        {
            var entity = db.Carts.FirstOrDefault(e => e.Id == src);
            db.Carts.Remove(entity);
            db.SaveChanges();
        }

        public List<Cart> GetCartByUsername(string uname)
        {
            var entity = (from e in db.Carts
                          where e.CustomerName == uname
                          select e).ToList();
            return entity;
        }

        public void MinusCart(int src)
        {
            var entity = db.Carts.FirstOrDefault(e => e.Id == src);
            entity.Quantity -= 1;
            db.SaveChanges();
        }

        public void PlusCart(int src)
        {
            var entity = db.Carts.FirstOrDefault(e => e.Id == src);
            entity.Quantity += 1;
            db.SaveChanges();
        }
    }
}
