using Microsoft.AspNetCore.Http;

namespace CoreP1.Areas.User.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
        public string PictureUrl { get; set; }
        public IFormFile Picture { get; set; }
    }
}
