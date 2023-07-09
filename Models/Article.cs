using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razorweb.models;
public class Article
{   
    // [Table("posts")]  ten cua bang trong sql server
    [Key]
    public int Id { get; set; }
    [StringLength(255)]
    [Required]
    [Column(TypeName = "nvarchar")]
    public string Title { get; set; }
    [DataType(DataType.Date)]
    [Required]
    public DateTime Create { get; set; }
    [Column(TypeName = "ntext")]
    public string Content { get; set; }
}