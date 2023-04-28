using CaloriesTrackingAPI.Context;
using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Data;

namespace CaloriesTrackingAPI.Repository
{
    public class MealsRepository : GenericRepository<Meal>, IMealsRepository
    {
        public MealsRepository(MealsDbContext context) : base(context)
        {
        }

        
    }
}
