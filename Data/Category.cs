using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenTranHoangPhat_Dl1.Data
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên danh mục không được để trống!!!")]
        // abcs
        [StringLength(150)]
        public string Title { get; set; }
        
        public string? Alias { get; set; }
        public string? Link { get; set; }
        [StringLength(150)]
        public string? Description { get; set; }
        public string? SeoTitle { get; set; }
        [StringLength(250)]
        public string? SeoDescription { get; set; }
        [StringLength(150)]
        public string? SeoKeywords { get; set; }
        public bool IsActive { get; set; }
        //public int Position { get; set; }
        //alo nghĩa
    }
}
