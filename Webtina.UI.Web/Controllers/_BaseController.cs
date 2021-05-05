using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webtina.UI.Core.Extentions;
using Webtina.UI.Framework.ActionFilters;
using Webtina.UI.Models;

namespace Webtina.UI.Web.Controllers
{
    [CheckCulture]
    public class _BaseController : Controller
    {
        public Tenant Tenant => HttpContext.GetTenant();
    }
}
