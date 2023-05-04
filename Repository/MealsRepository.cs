using CaloriesTrackingAPI.Context;
using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CaloriesTrackingAPI.Repository
{
    public class MealsRepository : GenericRepository<Meal>, IMealsRepository
    {
        private readonly MealsDbContext context;

        public MealsRepository(MealsDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<Meal>> GetUserMeals(string id)
        {
            var meals = await this.context.Meals.Where(meal => meal.MealsUserId == id).ToListAsync();

            if(meals == null)
            {
                return null;
            }

            return meals;

        }

        




    }
}
