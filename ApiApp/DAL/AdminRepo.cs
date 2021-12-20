using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminRepo : IRepo<Admin, string, string>, IAuth
    {
        KetabKhanaFEntities db;
        public AdminRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }

        public void Add(Admin e)
        {
            db.Admins.Add(e);
            db.SaveChanges();
        }

        

        public void Delete(Admin e)
        {
            var n = db.Admins.FirstOrDefault(en => en.Username == e.Username);
            db.Admins.Remove(n);
            db.SaveChanges();
        }

        public void Edit(Admin e)
        {
            var n = db.Admins.FirstOrDefault(en => en.Username == e.Username);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Admin> GetAll()
        {
            return db.Admins.ToList();
        }

        public Admin GetOne(string id)
        {
            return db.Admins.FirstOrDefault(e => e.Username == id);
        }




        //extra ############################################

        public void Add(Admin e, string src)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetByUsername(string src)
        {
            throw new NotImplementedException();
        }




        //IAuth ############################################
        public Token Authenticate(Login user)
        {
            var u = db.Admins.FirstOrDefault(en => en.Username == user.Username
            && en.Password == user.Password);
            Token t = null;
            if(u!= null)
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.UserName = u.Username;
                t.Type = "Admin";
                t.AccessToken = token;
                t.CreatedAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.AccessToken == token && e.ExpiredAt == null && e.Type == "Admin");
            return rs;
            

        }

        public bool Logout(string token)
        {
            throw new NotImplementedException();
        }
    }
}
