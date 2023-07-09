using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razorweb.models;
public class Article
{   
    // [Table("posts")]  ten cua bang trong sql server
    [Key]
    public int Id { get; set; }
    [DisplayName("Tiêu Đề")]
    [StringLength(255,MinimumLength = 5,ErrorMessage = "{0} phải dài từ {2} den {1}")]
    [Required(ErrorMessage ="{0} phải nhập")]
    [Column(TypeName = "nvarchar")]
    public string Title { get; set; }
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "{0} Phai nhap")]
    [DisplayName("Ngày Tạo")]

    public DateTime Create { get; set; }

    [DisplayName("Nội Dung")]
    [Column(TypeName = "ntext")]
    public string Content { get; set; }
}