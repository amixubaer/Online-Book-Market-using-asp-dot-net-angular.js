using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class TransactionRepo : IRepo<Transaction, string>
    {
        KetabKhanaFEntities db;
        public TransactionRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }


        public void Add(Transaction e)
        {
            db.Transactions.Add(e);
            db.SaveChanges();
        }

        public List<Transaction> GetAll()
        {
            return db.Transactions.ToList();
        }

        public List<Transaction> GetByCustomerName(string src)
        {
            var entity = (from e in db.Transactions
                          where e.CustomerName == src
                          select e).ToList();
            return entity;
        }

        public List<Transaction> GetByShopName(string src)
        {
            var entity = (from e in db.Transactions
                          where e.ShopName == src
                          select e).ToList();
            return entity;
        }
    }
}
