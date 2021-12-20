using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class StatementRepo : IRepo<Statement>
    {
        KetabKhanaFEntities db;
        public StatementRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }

        public void Add(Statement e)
        {
            db.Statements.Add(e);
            db.SaveChanges();
        }

        public List<Statement> GetAll()
        {
            return db.Statements.ToList();
        }
    }
}
