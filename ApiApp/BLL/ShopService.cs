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
    public class ShopService
    {
        public static void Add(ShopModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopModel, Shop>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Shop>(p);
            DataAccessFactory.ShopDataAcess().Add(data);
        }

    


        public static void Delete(ShopModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopModel, Shop>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Shop>(p);
            DataAccessFactory.ShopDataAcess().Delete(data);
        }

        public static void Edit(ShopModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopModel, Shop>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Shop>(p);
            DataAccessFactory.ShopDataAcess().Edit(data);
        }



        public static List<ShopModel> GetAllShops()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Shop, ShopModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ShopDataAcess();
            var data = mapper.Map<List<ShopModel>>(da.GetAllShops());
            return data;
        }

        public static ShopModel GetOneShop(string uname)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Shop, ShopModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ShopDataAcess();
            var data = mapper.Map<ShopModel>(da.GetOneShop(uname));
            return data;
        }

        public static void ApproveShop(string uname)
        {
            DataAccessFactory.ShopDataAcess().ApproveShop(uname);
        }

        public static void DeclineShop(string uname)
        {
            DataAccessFactory.ShopDataAcess().DeclineShop(uname);
        }

        public static List<ShopModel> GetPendingShop()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Shop, ShopModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ShopDataAcess();
            var data = mapper.Map<List<ShopModel>>(da.GetPendingShop());
            return data;
        }


        public static List<ShopModel> GetApprovedShop()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Shop, ShopModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ShopDataAcess();
            var data = mapper.Map<List<ShopModel>>(da.GetApprovedShop());
            return data;
        }



    }
}
