using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksMarketApp_EF_WF.DB.Entities;

[Table("BookPromotions")]
public class BookPromotion
{
    [Key, Column(Order = 0)]
    public int BookId { get; set; }

    [ForeignKey(nameof(BookId))]
    public virtual Book Book { get; set; }

    [Key, Column(Order = 1)]
    public int PromotionId { get; set; }

    [ForeignKey(nameof(PromotionId))]
    public virtual Promotion Promotion { get; set; }
}