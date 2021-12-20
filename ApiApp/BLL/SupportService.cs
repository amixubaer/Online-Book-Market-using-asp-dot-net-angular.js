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
    public class SupportService
    {
        public static void Add(SupportModel b)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SupportModel, Support>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Support>(b);
            DataAccessFactory.SupportDataAcess().Add(data);
        }

        public static List<SupportModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Support, SupportModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SupportDataAcess();
            var data = mapper.Map<List<SupportModel>>(da.GetAll());
            return data;
        }
    }
}
