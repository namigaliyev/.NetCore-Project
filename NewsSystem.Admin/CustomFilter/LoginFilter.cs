using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace NewsSystem.Admin.CustomFilter
{
    public class LoginFilter : Attribute, IActionFilter
    {
        const string SessionName = "UserEmail"; 
        private readonly IHttpContextAccessor _httpContextAccessor;
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // var  wrapper = new HttpContextWrapper(
            //                     _httpContextAccessor.HttpContext.User.Identities.Any(x => x.IsAuthenticated)
            // );

            var SessionControl = context.HttpContext.Session.GetString(SessionName);
            if(string.IsNullOrEmpty(SessionControl))
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary { { "controller","Account"}, { "action","Login"} }
                );
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}