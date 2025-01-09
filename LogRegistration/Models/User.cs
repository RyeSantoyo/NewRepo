using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LogRegistration.Models
{
    public class User : IdentityUser
    {
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
    }
}
