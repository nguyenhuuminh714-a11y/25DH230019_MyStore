using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _25DH230019_MyStore.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục")]
        [StringLength(100)]
        [Display(Name = "Tên danh mục")]
        public string CategoryName { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    
    }
}