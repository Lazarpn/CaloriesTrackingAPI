using System.ComponentModel.DataAnnotations;

namespace CaloriesTrackingAPI.Models.Users
{
    public class UserLoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
