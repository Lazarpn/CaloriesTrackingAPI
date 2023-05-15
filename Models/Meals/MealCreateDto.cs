namespace CaloriesTrackingAPI.Models.Meals;

public class MealCreateDto: BaseMealDto
{
    public Guid MealsUserId { get; set; }
}
