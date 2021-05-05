using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Webtina.UI.Core.Infrastructure;
using Webtina.UI.Core.MiddleWare;
using Webtina.UI.Services;
using Webtina.UI.Services.Middleware;
using Webtina.UI.Services.Services;
using Westwind.Globalization;
using Westwind.Globalization.AspnetCore;

namespace Webtina.UI.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddScoped<ITenantAccessor, TenantAccessor>();
            services.AddScoped<ITanentService, TanentService>();
            services.AddScoped<IDapperService<object>, DapperService<object>>();





            #region WestWind

            //// Standard ASP.NET Localization features are recommended
            //// Make sure this is done FIRST!
            //services.AddLocalization(options =>
            //{
            //    // I prefer Properties over the default `Resources` folder
            //    // due to namespace issues if you have a Resources type as
            //    // most people do for shared resources.
            //    options.ResourcesPath = "Properties";
            //});

            //// Replace StringLocalizers with Db Resource Implementation
            //services.AddSingleton(typeof(IStringLocalizerFactory),
            //                      typeof(DbResStringLocalizerFactory));
            //services.AddSingleton(typeof(IHtmlLocalizerFactory),
            //                      typeof(DbResHtmlLocalizerFactory));


            //// Required: Enable Westwind.Globalization (opt parm is optional)
            //// shown here with optional manual configuration code
            //services.AddWestwindGlobalization(opt =>
            //{
            //    // the default settings comme from DbResourceConfiguration.json if exists
            //    // you can override the settings here, the config you create is added
            //    // to the DI system (DbResourceConfiguration)

            //    // Resource Mode - from Database (or Resx for serving from Resources)
            //    opt.ResourceAccessMode = ResourceAccessMode.DbResourceManager;  // .Resx

            //    // Make sure the database you connect to exists
            //    opt.ConnectionString = "Data Source=.;Initial Catalog=CorpData;Integrated Security=True";

            //    // Database provider used - Sql Server is the default
            //    opt.DataProvider = DbResourceProviderTypes.SqlServer;

            //    // The table in which resources are stored
            //    opt.ResourceTableName = "localizations";

            //    opt.AddMissingResources = false;
            //    opt.ResxBaseFolder = "~/Properties/";

            //    // Set up security for Localization Administration form
            //    opt.ConfigureAuthorizeLocalizationAdministration(actionContext =>
            //    {
            //        // return true or false whether this request is authorized
            //        return true;   //actionContext.HttpContext.User.Identity.IsAuthenticated;
            //    });

            //});

            ////for LocalizationAdministration
            ////https://github.com/RickStrahl/Westwind.Globalization/issues/187#issuecomment-734911055
            //services.AddRazorPages()
            //    .AddNewtonsoftJson()
            //    .AddViewLocalization()
            //    .AddDataAnnotationsLocalization();



            #endregion




            //ViewLocationExpander 
            //برای اینکه پوشه ویو ها رو سرچ کنه
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new TenantViewLocationExpander());
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCustomExceptionHandler();//باید اولین میدلور باشه که بتونه همه خطاها رو بگیره
             
            app.UseHttpsRedirection();
            app.UseStaticFiles();
             
            app.UseMultiTenancy();



            #region WestWind

            //var supportedCultures = new[]
            //{
            //    new CultureInfo("fa"),
            //    new CultureInfo("en")
            //};
            //app.UseRequestLocalization(new RequestLocalizationOptions
            //{
            //    DefaultRequestCulture = new RequestCulture("fa"),
            //    SupportedCultures = supportedCultures,
            //    SupportedUICultures = supportedCultures
            //});

            #endregion




            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "DefaultLocalized",
                    pattern: "{culture=fa}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
