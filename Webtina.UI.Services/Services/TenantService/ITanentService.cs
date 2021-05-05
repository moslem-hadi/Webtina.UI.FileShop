using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Webtina.UI.Models;

namespace Webtina.UI.Services.Services
{
    public interface ITanentService
    {
        Task<Tenant> GetTenantAsync();
    }
}
