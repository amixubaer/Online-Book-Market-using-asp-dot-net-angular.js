using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepo : IRepo<Employee, string, string>, IAuth
    {
        KetabKhanaFEntities db;
        public EmployeeRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }



        public void Add(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
        }

        

        public void Delete(Employee e)
        {
            var n = db.Employees.FirstOrDefault(en => en.Username == e.Username);
            db.Employees.Remove(n);
            db.SaveChanges();
        }

        public void Edit(Employee e)
        {
            var n = db.Employees.FirstOrDefault(en => en.Username == e.Username);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        

        public Employee GetOne(string id)
        {
            return db.Employees.FirstOrDefault(e => e.Username == id);
        }

        //extra ############################################

        public void Add(Employee e, string src)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetByUsername(string src)
        {
            throw new NotImplementedException();
        }


        //IAuth ############################################
        public Token Authenticate(Login user)
        {
            var u = db.Employees.FirstOrDefault(en => en.Username == user.Username
            && en.Password == user.Password);
            Token t = null;
            if (u != null)
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.UserName = u.Username;
                t.Type = "Employee";
                t.AccessToken = token;
                t.CreatedAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.AccessToken == token && e.ExpiredAt == null && e.Type == "Employee");
            return rs;
        }

        public bool Logout(string token)
        {
            throw new NotImplementedException();
        }
    }
}
