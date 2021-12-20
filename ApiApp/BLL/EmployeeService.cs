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
    public class EmployeeService
    {
        public static void Add(EmployeeModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeModel, Employee>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(p);
            DataAccessFactory.EmployeeDataAcess().Add(data);
        }

        public static void Delete(EmployeeModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeModel, Employee>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(p);
            DataAccessFactory.EmployeeDataAcess().Delete(data);
        }

        public static void Edit(EmployeeModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeModel, Employee>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(p);
            DataAccessFactory.EmployeeDataAcess().Edit(data);
        }



        public static List<EmployeeModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.EmployeeDataAcess();
            var data = mapper.Map<List<EmployeeModel>>(da.GetAll());
            return data;
        }



        public static EmployeeModel GetOne(string id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.EmployeeDataAcess();
            var data = mapper.Map<EmployeeModel>(da.GetOne(id));
            return data;
        }
    }
}
