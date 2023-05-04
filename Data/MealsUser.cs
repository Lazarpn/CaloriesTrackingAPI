using Microsoft.AspNetCore.Identity;

namespace CaloriesTrackingAPI.Data
{
    public class MealsUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Meal> Meals { get; set; }

    }
}