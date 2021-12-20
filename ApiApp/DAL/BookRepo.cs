using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class BookRepo : IBook<Book, int, string>
    {
        KetabKhanaFEntities db;
        public BookRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }



        public void Add(Book e)
        {
            db.Books.Add(e);
            db.SaveChanges();
           
        }

       

        public void Delete(Book e)
        {
            var n = db.Books.FirstOrDefault(en => en.Id == e.Id);
            db.Books.Remove(n);
            db.SaveChanges();
        }

        public void Edit(Book e)
        {
            var n = db.Books.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return db.Books.ToList();
        }

        public List<Book> GetByUsername(string src)
        {
            var entity = (from e in db.Books
                          where e.ShopName == src
                          select e).ToList();
            return entity;
        }

        public Book GetOne(int id)
        {
            return db.Books.FirstOrDefault(e => e.Id == id);
        }

        public List<Book> SrcBook(string src)
        {
            var entity = (from e in db.Books
                          where e.Title == src
                          select e).ToList();
            return entity;
        }
    }
}
