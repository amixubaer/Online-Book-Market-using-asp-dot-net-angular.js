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
    public class CustomerService
    {
        public static void Add(CustomerModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerModel, Customer>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Customer>(p);
            DataAccessFactory.CustomerDataAcess().Add(data);
        }

        public static void Delete(CustomerModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerModel, Customer>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Customer>(p);
            DataAccessFactory.CustomerDataAcess().Delete(data);
        }

        public static void Edit(CustomerModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerModel, Customer>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Customer>(p);
            DataAccessFactory.CustomerDataAcess().Edit(data);
        }



        public static List<CustomerModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CustomerDataAcess();
            var data = mapper.Map<List<CustomerModel>>(da.GetAll());
            return data;
        }



        public static CustomerModel GetOne(string id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CustomerDataAcess();
            var data = mapper.Map<CustomerModel>(da.GetOne(id));
            return data;
        }
    }
}
