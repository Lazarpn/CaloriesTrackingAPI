using CaloriesTrackingAPI.Context;
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
    private readonly MealsDbContext context;

    public MealsController(MealsDbContext context)
    {
        this.context = context;
    }

    

    [HttpGet]
    public List<Meal> GetMeals()
    {
        return this.meals;
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Meal>> GetMeal(int id)
    {

        var meal = this.meals.FirstOrDefault(x => x.Id == id);

        if(meal == null)
        {
            return NotFound();
        }

        return Ok(meal);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<List<Meal>>> GetMeal(int id, Meal meal)
    {
        if (id != meal.Id)
        {
            return BadRequest("Invalid something");
        }


        var oldMeal = this.meals.FirstOrDefault(x => x.Id == id);

        if(oldMeal == null)
        {
            return NotFound();
        }

        oldMeal.Calories = meal.Calories;
        oldMeal.Date = meal.Date;
        oldMeal.Name = meal.Name;
        oldMeal.Time    = meal.Time;


        
        return this.meals;
    }

    [HttpPost]
    public async Task<ActionResult<List<Meal>>> AddMeal(Meal meal)
    {
        this.meals.Add(meal);

        return this.meals;
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult<List<Meal>>> DeleteMeal(int id)
    {
        var meal = this.meals.FirstOrDefault(meal => meal.Id == id);
        this.meals.Remove(meal);
        return this.meals;
    }

}
