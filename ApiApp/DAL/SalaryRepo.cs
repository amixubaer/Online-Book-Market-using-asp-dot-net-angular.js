using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class SalaryRepo : ISalary<Salary, int>
    {
        KetabKhanaFEntities db;
        public SalaryRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }


        public void Add(Salary e)
        {
            e.Status = "Pending";
            db.Salaries.Add(e);
            db.SaveChanges();
        }

        public void Approve(int id)
        {
            var salary = db.Salaries.FirstOrDefault(s => s.Id == id);
    
            salary.Status = "Approved";
            db.SaveChanges();
        }

        public void Decline(int id)
        {
            var salary = db.Salaries.FirstOrDefault(s => s.Id == id);
            salary.Status = "Declined";
            db.SaveChanges();
        }

        public List<Salary> GetApproved()
        {
            var entity = (from e in db.Salaries
                          where e.Status == "Approved"
                          select e).ToList();
            return entity;
        }

        public List<Salary> GetPending()
        {
            var entity = (from e in db.Salaries
                          where e.Status == "Pending"
                          select e).ToList();
            return entity;
        }
    }
}
