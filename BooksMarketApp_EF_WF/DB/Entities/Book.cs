using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksMarketApp_EF_WF.DB.Entities;

[Table("Book")]
public class Book
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int PublishingHouseId { get; set; }

    [ForeignKey(nameof(PublishingHouseId))]
    public virtual PublishingHouse PublishingHouse { get; set; }

    [Required]
    [StringLength(255)]
    public string BookTitle { get; set; }

    [StringLength(500)]
    public string? ImgUrl { get; set; }
    
    [Required]
    public int AuthorId { get; set; }

    [ForeignKey(nameof(AuthorId))]
    public virtual Author Author { get; set; }

    [Required]
    public int GenreId { get; set; }

    [ForeignKey(nameof(GenreId))]
    public virtual Genre Genre { get; set; }

    [Required]
    public int PagesNumber { get; set; }

    [Required]
    public double CostPrice { get; set; }

    [Required]
    public double SellingPrice { get; set; }
    
    public int? ParentBookId { get; set; }

    [ForeignKey(nameof(ParentBookId))]
    public virtual Book ParentBook { get; set; }

    [Required]
    public int PublishingYear { get; set; }

    // Connections
    public virtual ICollection<UserStorage> UserStorages { get; set; } = new List<UserStorage>();
    public virtual ICollection<SalesStatistic> SalesStatistics { get; set; } = new List<SalesStatistic>();
    public virtual ICollection<BookPromotion> BookPromotions { get; set; } = new List<BookPromotion>();
}