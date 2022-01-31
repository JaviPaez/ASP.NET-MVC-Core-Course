using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Web_App.Models
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}