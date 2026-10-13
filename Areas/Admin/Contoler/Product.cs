using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _25DH230019_MyStore.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        [StringLength(200)]
        [Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999",
            ErrorMessage = "Giá phải lớn hơn hoặc bằng 0")]
        [Column(TypeName = "decimal")]
        [Display(Name = "Giá")]
        public decimal Price { get; set; }

        [StringLength(500)]
        [Display(Name = "Ảnh sản phẩm")]
        public string ImageUrl { get; set; }

        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}