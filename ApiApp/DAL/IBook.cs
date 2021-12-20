using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IBook<T, ID, Src>
    {
        void Add(T e);
        void Edit(T e);
        void Delete(T e);
        List<T> GetAll();
        List<T> SrcBook(Src src);
        T GetOne(ID id);
        List<T> GetByUsername(Src src);

    }
}
