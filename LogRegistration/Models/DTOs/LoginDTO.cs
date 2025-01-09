using System.ComponentModel.DataAnnotations;

namespace LogRegistration.Models.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="This is a required field.")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name ="Remember me?")]
        public bool RememberMe { get; set; }
    }
}
