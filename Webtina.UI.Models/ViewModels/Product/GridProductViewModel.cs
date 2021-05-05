using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Framework.Helper;

namespace Webtina.UI.Models.ViewModels
{
    /// <summary>
    /// مدل برای باکس های گرید مانند
    /// </summary>
   public class GridProductViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Price { get; set; }

        public int OldPrice { get; set; }


        public string PriceDispay => Price.ToNumeric();

        public string OldPriceDispay => Price.ToNumeric();

    }
}
