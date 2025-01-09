using System.ComponentModel.DataAnnotations;

namespace LogRegistration.Models.DTOs
{
    public class VerifyEmail
    {
        [Required(ErrorMessage = "This is a required field.")]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
