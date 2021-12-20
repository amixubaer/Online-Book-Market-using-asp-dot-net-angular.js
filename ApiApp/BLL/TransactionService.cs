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
    public class TransactionService
    {
        public static void Add(TransactionModel b)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TransactionModel, Transaction>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Transaction>(b);
            DataAccessFactory.TransactionDataAcess().Add(data);
        }

        public static List<TransactionModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Transaction, TransactionModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.TransactionDataAcess();
            var data = mapper.Map<List<TransactionModel>>(da.GetAll());
            return data;
        }



        public static List<TransactionModel> GetByCustomerName(string src)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Transaction, TransactionModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.TransactionDataAcess();
            var data = mapper.Map<List<TransactionModel>>(da.GetByCustomerName(src));
            return data;
        }


        public static List<TransactionModel> GetByShopName(string src)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Transaction, TransactionModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.TransactionDataAcess();
            var data = mapper.Map<List<TransactionModel>>(da.GetByShopName(src));
            return data;
        }
    }
}
