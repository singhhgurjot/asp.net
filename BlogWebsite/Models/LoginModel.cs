using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace BlogWebsite.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }
    }
}
