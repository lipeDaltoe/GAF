using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAF.Api.Models;

[Table("transactions")]
public class Transaction
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(300)]
    public string Description { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    public TransactionType Type { get; set; }
    
    [Required]
    public DateTime TransactionDate { get; set; }

    [StringLength(1000)]
    public string Notes { get; set; }

    [Required]
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category Category { get; set; }
    
    [Required]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
