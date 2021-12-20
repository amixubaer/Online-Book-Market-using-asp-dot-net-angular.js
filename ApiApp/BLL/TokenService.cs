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
    public class TokenService
    {
        public static List<TokenModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.TokenDataAccess();
            var data = mapper.Map<List<TokenModel>>(da.GetAll());
            return data;

        }
        public static TokenModel Get(string token)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.TokenDataAccess();
            var data = mapper.Map<TokenModel>(da.Get(token));
            return data;

        }

        public static void Create(TokenModel token)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TokenModel, Token>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Token>(token);
            DataAccessFactory.TokenDataAccess().Add(data);
           

        }
        public static void Edit(TokenModel token)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TokenModel, Token>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Token>(token);
            DataAccessFactory.TokenDataAccess().Edit(data);


        }
        public static void Delete(string token)
        {
            DataAccessFactory.TokenDataAccess().Delete(token);
        }
    }
}
