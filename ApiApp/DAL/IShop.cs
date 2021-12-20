using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IShop<T, Uname>
    {
        void Add(T e);
        void Edit(T e);
        void Delete(T e);
        List<T> GetAllShops();

        List<T> GetPendingShop();
        List<T> GetApprovedShop();

        void ApproveShop(Uname uname);
        void DeclineShop(Uname uname);

        T GetOneShop(Uname uname);

    }
}
