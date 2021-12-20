using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepo : IRepo<Customer, string, string>, IAuth
    {
        KetabKhanaFEntities db;
        public CustomerRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }

        public void Add(Customer e)
        {
            db.Customers.Add(e);
            db.SaveChanges();
        }
        

        public void Delete(Customer e)
        {
            var orders = (from o in db.Orders
                          where o.CustomerName == e.Username
                          select o).ToList();

       
            foreach (var o in orders)
            {
                var details = (from od in db.OrderDetails
                               where od.OrderId == o.Id
                               select od).ToList();

                foreach (var d in details)
                {
                    db.OrderDetails.Remove(d);
                    db.SaveChanges();
                }
                db.Orders.Remove(o);
                db.SaveChanges();
            }



            var n = db.Customers.FirstOrDefault(en => en.Username == e.Username);
            db.Customers.Remove(n);
            db.SaveChanges();
        }

        public void Edit(Customer e)
        {
            var n = db.Customers.FirstOrDefault(en => en.Username == e.Username);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        

        public Customer GetOne(string id)
        {
            return db.Customers.FirstOrDefault(e => e.Username == id);
        }





        //extra ############################################

        public void Add(Customer e, string src)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetByUsername(string src)
        {
            throw new NotImplementedException();
        }


        //IAuth ############################################
        public Token Authenticate(Login user)
        {
            var u = db.Customers.FirstOrDefault(en => en.Username == user.Username
            && en.Password == user.Password);
            Token t = null;
            if (u != null)
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.UserName = u.Username;
                t.Type = "Customer";
                t.AccessToken = token;
                t.CreatedAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.AccessToken == token && e.ExpiredAt == null && e.Type == "Customer");
            return rs;
        }

        public bool Logout(string token)
        {
            var t = db.Tokens.FirstOrDefault(e => e.AccessToken == token);
            if(t!=null)
            {
                t.ExpiredAt = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
