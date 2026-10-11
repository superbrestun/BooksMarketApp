using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksMarketApp_EF_WF.DB.Entities;

[Table("Author")]
public class Author
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(150)]
    public string FullName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}