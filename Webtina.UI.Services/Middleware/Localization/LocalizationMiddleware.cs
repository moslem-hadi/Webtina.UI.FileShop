using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Webtina.UI.Services.Middleware
{
   public class LocalizationMiddleware
    {
        private readonly RequestDelegate _next;
        public LocalizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var x = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetDisplayUrl(context.Request);
            var c= context.GetRouteData().Values["culture"];

            await this._next(context);
        }
    }
}
