using Microsoft.AspNetCore.Identity;

namespace CaloriesTrackingAPI.Data
{
    public class MealsUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual IList<Meal> Meals { get; set; }

    }
}