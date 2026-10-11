using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksMarketApp_EF_WF.DB.Entities;

[Table("PublishingHouse")]
public class PublishingHouse
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(150)]
    public string Name { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}