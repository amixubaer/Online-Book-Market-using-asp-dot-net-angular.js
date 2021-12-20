using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CartService
    {
        public static void AddToCart(int src, string uname)
        {
            DataAccessFactory.CartDataAcess().AddToCart(src, uname);
        }

        public static List<CartModel> GetCartByUsername(string uname)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Cart, CartModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CartDataAcess();
            var data = mapper.Map<List<CartModel>>(da.GetCartByUsername(uname));
            return data;
        }

        public static void PlusCart(int src)
        {
            DataAccessFactory.CartDataAcess().PlusCart(src);
        }

        public static void MinusCart(int src)
        {
            DataAccessFactory.CartDataAcess().MinusCart(src);
        }

        public static void DeleteCart(int src)
        {
            DataAccessFactory.CartDataAcess().DeleteCart(src);
        }


        public static void ClearCart(string uname)
        {
            DataAccessFactory.CartDataAcess().ClearCart(uname);
        }
        


        
    }
}
