using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Webtina.UI.Framework.ActionFilters
{
    public class CheckCultureAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Get locale from route values
            string lang = (string)filterContext.RouteData.Values["culture"] ?? "fa";

            //// If we haven't found appropriate culture - seet default locale then
            //if (!_supportedLocales.Contains(lang))
            //    lang = _defaultLang;

            SetLang(lang);
        }
        private void SetLang(string lang)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);
        }
    }
}
