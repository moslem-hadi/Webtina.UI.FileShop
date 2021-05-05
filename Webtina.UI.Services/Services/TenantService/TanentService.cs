using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Webtina.UI.Models;

namespace Webtina.UI.Services.Services
{
    public class TanentService : ITanentService
    {
        public async Task<Tenant> GetTenantAsync()
        {
            var tenant= new Tenant
            {
                Theme = "Miver"
            };
            return await Task.FromResult(tenant);
        }
    }
}
