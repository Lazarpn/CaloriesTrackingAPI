using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace CaloriesTrackingAPI.Data
{
    public class MealsUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CaloriesPreference { get; set; } = null;
        public string? UserPhoto { get; set; } = null;


        [JsonIgnore]
        public ICollection<Meal> Meals { get; set; }


    }
}