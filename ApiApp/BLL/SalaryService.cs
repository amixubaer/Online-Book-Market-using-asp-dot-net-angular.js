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
    public class SalaryService
    {
        public static void Add(SalaryModel b)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryModel, Salary>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Salary>(b);
            DataAccessFactory.SalaryDataAcess().Add(data);
        }

        public static void Approve(int id)
        {
            DataAccessFactory.SalaryDataAcess().Approve(id);
        }

        public static void Decline(int id)
        {
            DataAccessFactory.SalaryDataAcess().Decline(id);
        }


        public static List<SalaryModel> GetApproved()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary, SalaryModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SalaryDataAcess();
            var data = mapper.Map<List<SalaryModel>>(da.GetApproved());
            return data;
        }

        public static List<SalaryModel> GetPending()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary, SalaryModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SalaryDataAcess();
            var data = mapper.Map<List<SalaryModel>>(da.GetPending());
            return data;
        }


    }
}
