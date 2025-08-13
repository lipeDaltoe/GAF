using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAF.Api.Models;

[Table("categories")]
public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    [StringLength(7)]
    public string Color { get; set; } = "#000000";

    [Required]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual User User { get; set; }
}
