using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Models;

namespace Webtina.UI.Services.Services
{
    public interface ITenantAccessor 
    {
        Tenant Tenant { get; }
    }
}
