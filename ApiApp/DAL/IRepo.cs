using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepo<T>
    {
        void Add(T e);
        List<T> GetAll();

    }

    public interface IRepo<T, Src>
    {
        void Add(T e);
        List<T> GetAll();
        List<T> GetByCustomerName(Src src);
        List<T> GetByShopName(Src src);

    }

    public interface IRepo<T, ID, Src>
    {
        void Add(T e);
        void Add(T e, Src src);
        void Edit(T e);
        void Delete(T e);
        List<T> GetAll();
        T GetOne(ID id);
        List<T> GetByUsername(Src src);

    }

    public interface IRepo<T, ID, Src, Status>
    {
        void Add(T e);
        void Add(T e, Src src);
        void Edit(T e);
        void Delete(T e);
        List<T> GetAll();
        T GetOne(ID id);
        List<T> GetByStatus(Status status);
        List<T> GetByUsername(Src src);
        void Approve(T e);
        void Decline(T e);
    }
}
