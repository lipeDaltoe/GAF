using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAF.Api.Models;

[Table("reports")]
public class Report
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int Month { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalIncome { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalExpenses { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Balance => TotalIncome - TotalExpenses;

    [Required]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual User User { get; set; }

    public DateTime GeneratedAt { get; set; }

}
