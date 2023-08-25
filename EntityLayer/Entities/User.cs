using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id{ get; set; }


        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Maksimum 50 Karakter Olmalıdır.")]
        public string Name{ get; set; }


        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "Maksimum 50 Karakter Olmalıdır.")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Email")]
        [StringLength(50, ErrorMessage = "Maksimum 50 Karakter Olmalıdır.")]
        [EmailAddress(ErrorMessage ="Mail formatı şeklinde giriniz!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "Maksimum 50 Karakter Olmalıdır.")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Şifre")]
        [StringLength(50, ErrorMessage = "Maksimum 10 Karakter Olmalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Şifre")]
        [StringLength(50, ErrorMessage = "Maksimum 10 Karakter Olmalıdır.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string Repassword { get; set; }

        [StringLength(50, ErrorMessage = "Maksimum 10 Karakter Olmalıdır.")]
        public string Role { get; set; }






    }
}
