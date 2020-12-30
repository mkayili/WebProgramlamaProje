using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "Ürün başlığı")]
        [MaxLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Ürün Açıklaması")]
        [MaxLength(250, ErrorMessage = "Maksimum 250 karakter girebilirsiniz")]
        public string Explanation { get; set; }

        [Required]
        [Display(Name = "Ürün Fiyatı")]
        public int Price { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
