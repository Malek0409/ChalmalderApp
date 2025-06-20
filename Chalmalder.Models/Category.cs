using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Chalmalder.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Category Name")]
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="The field to between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
