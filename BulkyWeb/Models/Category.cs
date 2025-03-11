using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required, MaxLength(250)]
    [DisplayName("Category Name")]
    public required string Name { get; set; }
    [Required]
    [DisplayName("Display Order")]
    public int DisplayOrder { get; set; }
}
