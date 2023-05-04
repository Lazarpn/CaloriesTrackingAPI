using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace CaloriesTrackingAPI.Data
{
    public class MealsUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonIgnore]
        public ICollection<Meal> Meals { get; set; }

    }
}