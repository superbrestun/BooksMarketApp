using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksMarketApp_EF_WF.DB.Entities;

[Table("Users")]
public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Login { get; set; }

    [Required]
    [StringLength(255)]
    public string Password { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; }

    [Required]
    public bool AdminPermission { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    // Feedback
    public virtual ICollection<UserStorage> UserStorages { get; set; } = new List<UserStorage>();
}