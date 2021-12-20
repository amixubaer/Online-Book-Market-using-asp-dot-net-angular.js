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
    public class StatementService
    {
        public static void Add(StatementModel b)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StatementModel, Statement>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Statement>(b);
            DataAccessFactory.StatementDataAcess().Add(data);
        }

        public static List<StatementModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Statement, StatementModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.StatementDataAcess();
            var data = mapper.Map<List<StatementModel>>(da.GetAll());
            return data;
        }
    }
}
