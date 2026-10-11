using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksMarketApp_EF_WF.DB.Entities;

[Table("SalesStatistics")]
public class SalesStatistic
{
    [Key]
    public int Id { get; set; } 

    [Required]
    public int BookId { get; set; }

    [ForeignKey(nameof(BookId))]
    public virtual Book Book { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public double SoldPrice { get; set; }

    [Required]
    public int CustomerId { get; set; }

    [Required]
    public DateTime SoldAt { get; set; }
}