using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="Username must be between 5 to 15 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 to 20 characters.")]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage ="Must be an email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password verification is required.")]
        public string VerifyPassword { get; set; }
    }
}
