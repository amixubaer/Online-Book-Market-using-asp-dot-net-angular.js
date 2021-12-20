using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICart<T, Src, Uname>
    {
        void AddToCart(Src src, Uname uname);
        void PlusCart(Src src);
        void MinusCart(Src src);
        void DeleteCart(Src src);
        void ClearCart(Uname uname);
        List<T> GetCartByUsername(Uname uname);
    }
}
