using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ComeToEgypt.Models
{
    public class Tourist
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Full Name is Required")]
        public string Fname { get; set; }
        public string? Lname { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is Required")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Profile Picture")]
        public string? ProfilePictureURL { get; set; }
    }
}
