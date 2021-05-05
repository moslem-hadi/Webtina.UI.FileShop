using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webtina.UI.Core.Extentions;

namespace Webtina.UI.Core.Infrastructure
{
    /// <summary>
    /// اضافه کردن محل های سرچ کردن برای ویوها
    /// با توجه به تم سایت، پوشه مورد نظر اضافه میشه.
    /// https://benfoster.io/blog/asp-net-core-themes-and-multi-tenancy/
    /// </summary>
    public class TenantViewLocationExpander : IViewLocationExpander
    {
        private const string THEME_KEY = "theme";
        public void PopulateValues(ViewLocationExpanderContext context)
        {
            context.Values[THEME_KEY] = context.ActionContext.HttpContext.GetTenant()?.Theme;
        }
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            if (context.Values.TryGetValue(THEME_KEY, out string theme))
            {
                viewLocations = new[] 
                {
                    $"/Themes/{theme}/{{1}}/{{0}}.cshtml",
                    $"/Themes/{theme}/Shared/{{0}}.cshtml",
                }.Concat(viewLocations);
            }

            return viewLocations;
        }
    }
}
