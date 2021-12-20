using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ApiApp.Auth
{
    public class CustomAdminAuth : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authheader = actionContext.Request.Headers.Authorization;
            if(authheader == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "No Token Found");
            }
            else
            {
                if(AuthService.IsAuthenticated(authheader.ToString())=="Admin")
                {

                }

                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Token is expired");
                }
            }


            base.OnAuthorization(actionContext);
        }


    }
}