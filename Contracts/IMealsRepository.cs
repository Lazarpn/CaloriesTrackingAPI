using CaloriesTrackingAPI.Data;

namespace CaloriesTrackingAPI.Contracts;

public interface IMealsRepository: IGenericRepository<Meal>
{
    public Task<List<Meal>> GetUserMeals(Guid id);
}
