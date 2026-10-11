using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksMarketApp_EF_WF.DB.Entities;

[Table("UserStorage")]
public class UserStorage
{
    // Combination key
    [Key, Column(Order = 0)]
    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; }

    [Key, Column(Order = 1)]
    public int BookId { get; set; }

    [ForeignKey(nameof(BookId))]
    public virtual Book Book { get; set; }

    [Required]
    public DateTime AddedAt { get; set; }

    [Required]
    public BookStatus Status { get; set; }
}