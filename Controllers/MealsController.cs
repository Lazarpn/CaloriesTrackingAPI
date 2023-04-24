using CaloriesTrackingAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CaloriesTrackingAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class MealsController : ControllerBase 
{
    private readonly List<Meal> meals = new List<Meal> {
        new Meal {
            Id = 1,
            Name = "banana",
            Date = "12",
            Calories = 20,
            Time = "kad god" } ,
        new Meal {
            Id = 2,
            Name = "tost",
            Date = "12",
            Calories = 20,
            Time = "kad god" },
        new Meal {
            Id = 3,
            Name = "sta-god",
            Date = "12",
            Calories = 20,
            Time = "kad god" }

    };
    public MealsController()
    {
        
    }

    [HttpGet]
    public List<Meal> GetMeals()
    {
        return this.meals;
    }

    [HttpGet]
    [Route("{id}")]
    public Meal GetMeal(int id)
    {

        

        return this.meals.FirstOrDefault(meal => meal.Id == id);
    }

    [HttpPut]
    [Route("{id}")]
    public List<Meal> GetMeal(int id, Meal meal)
    {
        

        return this.meals;
    }

    [HttpPost]
    public List<Meal> AddMeal(Meal meal)
    {
        this.meals.Add(meal);

        return this.meals;
    }

    [HttpDelete]
    [Route("{id}")]
    public List<Meal> DeleteMeal(int id)
    {
        var meal = this.meals.FirstOrDefault(meal => meal.Id == id);
        this.meals.Remove(meal);
        return this.meals;
    }

}
