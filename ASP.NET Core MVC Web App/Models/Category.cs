using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_MVC_Web_App.Models
{
    public class Category : EntityBase
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Display order must be greater than 0")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}