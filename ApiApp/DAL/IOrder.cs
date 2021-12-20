using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IOrder<T, ID, Uname, Od>
    {
        void Checkout(Uname uname, Od Od);
        void ReqCancel(ID id);
        void ApproveCancel(ID id);
        void DeclineCancel(ID id);
        List<T> GetOrderByCustomerName(Uname uname);
        List<T> GetCanceledOrderByCustomerName(Uname uname);
        List<T> GetAllOrders();
        List<T> GetAllCanceledOrders();
        List<T> GetAllCancelRequestOrders();

    }
}
