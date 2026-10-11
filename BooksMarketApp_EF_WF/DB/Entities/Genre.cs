using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksMarketApp_EF_WF.DB.Entities;

[Table("Genres")]
public class Genre
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column("Genre")]// mapping
    public string GenreName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}