using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Web_App.Models
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}