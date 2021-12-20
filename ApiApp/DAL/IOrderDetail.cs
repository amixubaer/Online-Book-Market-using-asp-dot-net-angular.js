using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IOrderDetail<T, Src, ID>
    {
        void Add(T e);
        List<T> GetAll();
        List<T> GetByCustomerName(Src src);
        List<T> GetByShopName(Src src);
        List<T> GetDetail(ID id);

    }
}
