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
    public class AuthService
    {
        public static TokenModel Authenticate(LoginModel user)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<LoginModel, Login>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Login>(user);


            var resultA = DataAccessFactory.AdminAuthDataAccess().Authenticate(data);
            var resultC = DataAccessFactory.CustomerAuthDataAccess().Authenticate(data);
            var resultS = DataAccessFactory.ShopAuthDataAccess().Authenticate(data);
            var resultE = DataAccessFactory.EmployeeAuthDataAccess().Authenticate(data);



            var token = new TokenModel();

            var config2 = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenModel>();
            });
            var mapper2 = new Mapper(config2);



            if (resultA != null)
            {              
                token = mapper2.Map<TokenModel>(resultA);  
            }
            else if (resultC != null)
            {    
                token = mapper2.Map<TokenModel>(resultC);
            }
            else if (resultS != null)
            {
                token = mapper2.Map<TokenModel>(resultS);
            }
            else if (resultE != null)
            {
                token = mapper2.Map<TokenModel>(resultE);
            }
            else
            {
                token = null;
            }

            return token;

        }

        public static string IsAuthenticated(string token)
        {
            string rs;
            if (DataAccessFactory.AdminAuthDataAccess().IsAuthenticated(token))
            {
                rs = "Admin";
                return rs;
            }
            else if (DataAccessFactory.CustomerAuthDataAccess().IsAuthenticated(token))
            {
                rs = "Customer";
                return rs;
            }

            else if (DataAccessFactory.EmployeeAuthDataAccess().IsAuthenticated(token))
            {
                rs = "Employee";
                return rs;
            }

            else if (DataAccessFactory.ShopAuthDataAccess().IsAuthenticated(token))
            {
                rs = "Shop";
                return rs;
            }
            else
                return "Not Found";


        }

        public static bool Logout(String token)
        {
            return DataAccessFactory.CustomerAuthDataAccess().Logout(token);


        }



    }
}
