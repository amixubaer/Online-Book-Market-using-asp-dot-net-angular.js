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
    public class AdminService
    {
        public static void Add(AdminModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminModel, Admin>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(p);
            DataAccessFactory.AdminDataAcess().Add(data);
        }

        public static void Delete(AdminModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminModel, Admin>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(p);
            DataAccessFactory.AdminDataAcess().Delete(data);
        }

        public static void Edit(AdminModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminModel, Admin>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(p);
            DataAccessFactory.AdminDataAcess().Edit(data);
        }



        public static List<AdminModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.AdminDataAcess();
            var data = mapper.Map<List<AdminModel>>(da.GetAll());
            return data;
        }



        public static AdminModel GetOne(string id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.AdminDataAcess();
            var data = mapper.Map<AdminModel>(da.GetOne(id));
            return data;
        }


    }
}
