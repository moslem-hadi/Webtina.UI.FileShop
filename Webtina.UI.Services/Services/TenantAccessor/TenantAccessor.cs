using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Core.Extentions;
using Webtina.UI.Models;

namespace Webtina.UI.Services.Services
{
    /*
     In ASP.NET Core, to access the HttpContext in services you use the IHttpContextAccessor service, to provide
    a familiar access pattern to the Tenant information for a developer working on our application we can create
    a ITenantAccessor service. This will make the library feel familiar to developers used to the existing pattern.
    https://michael-mckenna.com/multi-tenant-asp-dot-net-core-application-tenant-resolution


    Now if a downstream developer wants to add a service to your app which needs to access the current tenant context
    they can just inject ITenantAccessor<T> in the exact same way as using IHttpContextAccessor
     */
    public class TenantAccessor : ITenantAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TenantAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Tenant Tenant => _httpContextAccessor.HttpContext.GetTenant();
    }
}
