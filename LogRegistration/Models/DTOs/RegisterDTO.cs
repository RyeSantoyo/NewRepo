using System.ComponentModel.DataAnnotations;

namespace LogRegistration.Models.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "This is a required field.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string? Firstname { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string? Lastname { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string? Position { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string? Manager { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string? Empnumber { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }
    }
}


