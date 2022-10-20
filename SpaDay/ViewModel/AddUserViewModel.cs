using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public  class AddUserViewModel


    {
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "User name must between 5 and 15 character")]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "User password must be between 6 and 20 characters")]
        public string Password { get; set; }
        [Required]
        public string VerifyPassword { get; set; }
    }
}
