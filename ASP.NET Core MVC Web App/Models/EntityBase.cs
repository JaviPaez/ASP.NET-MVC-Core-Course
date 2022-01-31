using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_MVC_Web_App.Models
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}