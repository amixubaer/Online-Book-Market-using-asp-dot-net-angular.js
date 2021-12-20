﻿using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class RegistrationController : ApiController
    {
        [Route("api/Registration/AddCustomer")]
        [HttpPost]
        public void AddCustomer(CustomerModel s)
        {
            CustomerService.Add(s);
        }

        [Route("api/Registration/AddShop")]
        [HttpPost]
        public void AddShop(ShopModel s)
        {
            ShopService.Add(s);
        }
    }
}
