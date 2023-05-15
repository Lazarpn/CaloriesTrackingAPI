using CaloriesTrackingAPI.Context;
using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CaloriesTrackingAPI.Repository;

public class MealsRepository : GenericRepository<Meal>, IMealsRepository
{
    private readonly MealsDbContext db;

    public MealsRepository(MealsDbContext db) : base(db)
    {
        this.db = db;
    }

    public async Task<List<Meal>> GetUserMeals(Guid id)
    {
        var meals = await db.Meals.Where(meal => meal.MealsUserId == id).ToListAsync();

        if (meals == null)
        {
            return null;
        }

        return meals;

    }
}
