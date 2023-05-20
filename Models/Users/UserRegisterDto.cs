using System.ComponentModel.DataAnnotations;

namespace CaloriesTrackingAPI.Models.Users;

public class UserRegisterDto: UserLoginDto
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
}
