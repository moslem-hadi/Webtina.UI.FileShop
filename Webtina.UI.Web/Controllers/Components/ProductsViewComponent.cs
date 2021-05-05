using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webtina.UI.Web.Controllers.Components
{
    public class ProductsViewComponent : ViewComponent
    {
        public ProductsViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync(int maxPriority, bool isDone)
        {
            var items = await GetItemsAsync(maxPriority, isDone);
            return View(items);
        }
    }
}
