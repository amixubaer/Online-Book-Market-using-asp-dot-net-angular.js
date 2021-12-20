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
    public class OrderDetailService
    {
        public static List<OrderDetailModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetail, OrderDetailModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDetailDataAcess();
            var data = mapper.Map<List<OrderDetailModel>>(da.GetAll());
            return data;
        }

        public static List<OrderDetailModel> GetDetail(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetail, OrderDetailModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDetailDataAcess();
            var data = mapper.Map<List<OrderDetailModel>>(da.GetDetail(id));
            return data;
        }



        public static List<OrderDetailModel> GetByShopName(string src)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetail, OrderDetailModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDetailDataAcess();
            var data = mapper.Map<List<OrderDetailModel>>(da.GetByShopName(src));
            return data;
        }

        public static List<OrderDetailModel> GetByCustomerName(string src)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetail, OrderDetailModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDetailDataAcess();
            var data = mapper.Map<List<OrderDetailModel>>(da.GetByCustomerName(src));
            return data;
        }


    }
}
