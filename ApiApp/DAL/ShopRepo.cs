using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShopRepo : IShop<Shop, string>, IAuth
    {
        KetabKhanaFEntities db;
        public ShopRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }

        public void Add(Shop e)
        {
            e.Status = "Pending";
            db.Shops.Add(e);
            db.SaveChanges();
        }

        public void ApproveShop(string uname)
        {
            var shop = db.Shops.FirstOrDefault(e => e.Username == uname);
            shop.Status = "Approved";
            db.SaveChanges();
            
        }

        public void DeclineShop(string uname)
        {
            var shop = db.Shops.FirstOrDefault(e => e.Username == uname);
            shop.Status = "Declined";
            db.SaveChanges();
        }

        public void Delete(Shop e)
        {
            var books = (from b in db.Books
                          where b.ShopName == e.Username
                          select b).ToList();

            foreach (var b in books)
            {
                
                db.Books.Remove(b);
                db.SaveChanges();
            }


            var n = db.Shops.FirstOrDefault(en => en.Username == e.Username);
            db.Shops.Remove(n);
            db.SaveChanges();
        }

        public void Edit(Shop e)
        {
            var n = db.Shops.FirstOrDefault(en => en.Username == e.Username);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Shop> GetAllShops()
        {
            return db.Shops.ToList();
        }

        public Shop GetOneShop(string uname)
        {
            return db.Shops.FirstOrDefault(e => e.Username == uname);
        }


        public List<Shop> GetPendingShop()
        {
            var shops = (from s in db.Shops
                         where s.Status == "Pending"
                         select s).ToList();
            return shops;
        }

        public List<Shop> GetApprovedShop()
        {
            var shops = (from s in db.Shops
                               where s.Status == "Approved"
                               select s).ToList();
            return shops;
        }



        //IAuth ############################################
        public Token Authenticate(Login user)
        {
            var u = db.Shops.FirstOrDefault(en => en.Username == user.Username
            && en.Password == user.Password && en.Status == "Approved");
            Token t = null;
            if (u != null)
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.UserName = u.Username;
                t.Type = "Shop";
                t.AccessToken = token;
                t.CreatedAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.AccessToken == token && e.ExpiredAt == null && e.Type == "Shop");
            return rs;
        }

        public bool Logout(string token)
        {
            throw new NotImplementedException();
        }
    }
}
