using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CaloriesTrackingAPI.Data;

public class MealsUser : IdentityUser<Guid>
{

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    //[MaxLength(100, ErrorMessage = "Last name must be max 100 characters")]

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [Range(0, 20000)]
    public int CaloriesPreference { get; set; }
    public byte[] UserPhotoByte { get; set; }


    
    [InverseProperty(nameof(Meal.MealsUser))]
    public ICollection<Meal> Meals { get; set; } = new HashSet<Meal>();


}