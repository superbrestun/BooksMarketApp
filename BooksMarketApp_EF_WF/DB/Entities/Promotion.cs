using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksMarketApp_EF_WF.DB.Entities;

[Table("Promotions")]
public class Promotion
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(150)]
    public string Name { get; set; }

    [Required]
    [Column("DiscountPrecent")]
    public double DiscountPercent { get; set; } 

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    public virtual ICollection<BookPromotion> BookPromotions { get; set; } = new List<BookPromotion>();
}