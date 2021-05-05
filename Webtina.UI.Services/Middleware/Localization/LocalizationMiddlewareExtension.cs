using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webtina.UI.Services.Middleware
{
    public static class LocalizationMiddlewareExtension
    {
        public static IApplicationBuilder UseCulture(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LocalizationMiddleware>();
        }
    }
}
