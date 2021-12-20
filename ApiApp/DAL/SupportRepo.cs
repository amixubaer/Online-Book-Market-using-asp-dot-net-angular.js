using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class SupportRepo : IRepo<Support>
    {
        KetabKhanaFEntities db;
        public SupportRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }



        public void Add(Support e)
        {
            db.Supports.Add(e);
            db.SaveChanges();
        }

        public List<Support> GetAll()
        {
            return db.Supports.ToList();
        }
    }
}
