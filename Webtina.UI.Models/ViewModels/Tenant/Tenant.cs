using System;
using System.Collections.Generic;
using System.Text;

namespace Webtina.UI.Models
{
    public class Tenant
    {
        public string Theme { get; set; }

        

        /// <summary>
        /// Tenant items
        /// </summary>
        public Dictionary<string, object> Items { get; private set; } = new Dictionary<string, object>();
    }
}
