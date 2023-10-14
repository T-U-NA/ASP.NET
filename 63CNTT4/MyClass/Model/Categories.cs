using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//Muc dich thiet lap cac truong [KEY],[REQUIRED]
using System.ComponentModel.DataAnnotations.Schema;//Muc dich: Tap ra bang (table) co ten duoc dinh danh la [Table("Categories"]
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table ("Categories")]   
    
    public class Categories
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name ="Tên loại SP")]
        public string Name { get; set; }
        [Display(Name = "Tên rút gọn")]
        public String Slug {  get; set; }
        [Display(Name = "Cấp cha")]
        public int ParentID { get; set; }
        [Display(Name = "Sắp xếp")]
        public int? Order { get; set; }
        [Required]
        [Display(Name = "Mô tả")]
        public string MetaDesc { get; set; }
        [Required]
        [Display(Name = "Từ khóa")]
        public string MetaKey { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreateAt { get; set; }
        [Display(Name = "Tạo bởi")]
        public int CreateBy { get; set; }
        [Display(Name = "Ngày cập nhật")]
        public DateTime UpdateAt { get; set; }
        [Display(Name = "Cập nhập bởi")]
        public int UpdateBy { get; set; }
        [Display(Name = "Trạng thái")]
        public int Status { get; set; }
    }
}
