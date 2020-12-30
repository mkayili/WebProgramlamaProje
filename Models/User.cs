using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class User
    {
        public int UserID { get; set; }
        
        [Required]
        [Display(Name = "Ad")]
        [MaxLength(20, ErrorMessage = "Maksimum 20 karakter girebilirsiniz")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Soyad")]
        [MaxLength(20, ErrorMessage = "Maksimum 20 karakter girebilirsiniz")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Doğum Tarihi")]
        public string BirthDate { get; set; }

        [Required]
        [Display(Name = "Kullanıcı Adı")]
        [MaxLength(20, ErrorMessage = "Maksimum 20 karakter girebilirsiniz")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Parola")]
        [MaxLength(20, ErrorMessage = "Maksimum 20 karakter girebilirsiniz")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Email")]
        [MaxLength(30, ErrorMessage = "Maksimum 30 karakter girebilirsiniz")]
        public string Email { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Adres")]
        public string Adress { get; set; }

        public ICollection<Product> Products { get; set; }



    }
}