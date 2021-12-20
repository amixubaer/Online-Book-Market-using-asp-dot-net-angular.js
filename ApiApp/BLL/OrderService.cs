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
    public class OrderService
    {
        public static void Checkout(string uname, List<BookModel> od)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BookModel, Book>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDataAcess();
            var data = mapper.Map<List<Book>>(od);

            DataAccessFactory.OrderDataAcess().Checkout(uname, data);
        }

        public static List<OrderModel> GetAllOrders()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDataAcess();
            var data = mapper.Map<List<OrderModel>>(da.GetAllOrders());
            return data;
        }


        public static List<OrderModel> GetAllCancelRequestOrders()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDataAcess();
            var data = mapper.Map<List<OrderModel>>(da.GetAllCancelRequestOrders());
            return data;
        }

        public static List<OrderModel> GetAllCanceledOrders()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDataAcess();
            var data = mapper.Map<List<OrderModel>>(da.GetAllCanceledOrders());
            return data;
        }


        public static List<OrderModel> GetOrderByCustomerName(string uname)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDataAcess();
            var data = mapper.Map<List<OrderModel>>(da.GetOrderByCustomerName(uname));
            return data;
        }

        public static List<OrderModel> GetCanceledOrderByCustomerName(string uname)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDataAcess();
            var data = mapper.Map<List<OrderModel>>(da.GetCanceledOrderByCustomerName(uname));
            return data;
        }


        public static void ReqCancel(int id)
        {
            DataAccessFactory.OrderDataAcess().ReqCancel(id);
        }

        public static void ApproveCancel(int id)
        {
            DataAccessFactory.OrderDataAcess().ApproveCancel(id);
        }

        public static void DeclineCancel(int id)
        {
            DataAccessFactory.OrderDataAcess().DeclineCancel(id);
        }



    }
}
