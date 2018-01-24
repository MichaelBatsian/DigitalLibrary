using System.ComponentModel.DataAnnotations;

namespace Godeltech.Mastery.Web.DigitalLibrary.Models.View.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Did you forget enter your email?")]
        [Display(Name = "Email")]
        //[EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Did you forget enter your password?")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}