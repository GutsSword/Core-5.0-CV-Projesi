using System.ComponentModel.DataAnnotations;

namespace CoreP1.Areas.User.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adını giriniz")]
        public string Username  { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi giriniz")]
        public string Password { get; set; }
    }
}
