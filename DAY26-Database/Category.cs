using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAY26_Database;

public class Category
{
    [Key] // ini sebenarnya tidak perlu ditulis, wajib ditulis jika nama kolomnya tidak mengandung ID
    public int CategoryID { get; set; }

    [Required]
    [StringLength(15)]
    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string? Description { get; set; }
    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

    public Category()
    {
        Products = new HashSet<Product>();
    }
}
