using AutoMapper;
using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Models.Meals;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CaloriesTrackingAPI.Controllers;

[Route("[controller]")]
[ApiController]
[Authorize]
public class MealsController : ControllerBase
{
    private readonly IMapper mapper;
    private readonly IUserRepository userRepository;
    private readonly IMealsRepository mealsRepository;

    public MealsController(IMealsRepository mealsRepository, IMapper mapper, IUserRepository userRepository)
    {
        this.mealsRepository = mealsRepository;
        this.mapper = mapper;
        this.userRepository = userRepository;
    }



    [HttpGet]
    [Route("meals/{id:guid}")]
    [Authorize]
    public async Task<ActionResult<List<MealGetDto>>> GetUserMeals(Guid id)
    {
        var meals = await this.mealsRepository.GetUserMeals(id);

        if (meals == null)
        {
            return BadRequest();
        }

        var records = this.mapper.Map<List<MealGetDto>>(meals);
        return Ok(records);
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult<MealGetDto>> AddMeal(MealCreateDto createMeal)
    {
        var user = await userRepository.GetUser(createMeal.MealsUserId);
        var meal = mapper.Map<Meal>(createMeal);
        meal.MealsUser = user;
        await mealsRepository.AddAsync(meal);
        user.Meals.Add(meal);
        var mealGet = mapper.Map<MealGetDto>(meal);
        return mealGet;
    }

    [HttpGet]
    [Route("{id:guid}")]
    [Authorize]
    public async Task<ActionResult<MealGetDto>> GetMeal(Guid id)
    {

        var meal = await this.mealsRepository.GetAsync(id);

        if (meal == null)
        {
            return NotFound();
        }

        var record = this.mapper.Map<MealGetDto>(meal);
        return Ok(record);
    }

    [HttpPut]
    [Route("meal/{id:guid}")]
    [Authorize]
    public async Task<ActionResult<List<Meal>>> ChangeMeal(Guid id, MealUpdateDto updateMeal)
    {
        if (id != updateMeal.Id)
        {
            return BadRequest("Invalid something");
        }



        var meal = await this.mealsRepository.GetAsync(id);

        if (meal == null)
        {
            return NotFound();
        }

        this.mapper.Map(updateMeal, meal);

        await this.mealsRepository.UpdateAsync(meal);

        return await this.mealsRepository.GetAllAsync();
    }


    [HttpDelete]
    [Route("{id:guid}")]
    [Authorize]
    public async Task<ActionResult<List<Meal>>> DeleteMeal(Guid id)
    {
        var meal = await this.mealsRepository.GetAsync(id);

        if (meal == null)
        {
            return NotFound();
        }

        await this.mealsRepository.DeleteAsync(id);

        return NoContent();
    }

}
