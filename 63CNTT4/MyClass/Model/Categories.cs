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
        public string Name { get; set; }
        public String Slug {  get; set; }
        public int ParentID { get; set; }
        public int? Order { get; set; }
        [Required]
        public string MetaDesc { get; set; }
        [Required]
        public string MetaKey { get; set; }
        public DateTime CreateAt { get; set; }
        public int CreateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public int UpdateBy { get; set; }
        public int Status { get; set; }
    }
}
