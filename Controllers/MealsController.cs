using AutoMapper;
using CaloriesTrackingAPI.Context;
using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Models.Meals;
using CaloriesTrackingAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaloriesTrackingAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class MealsController : ControllerBase 
{
    private readonly IMapper mapper;
    private readonly MealsRepository mealsRepository;

    public MealsController(MealsRepository mealsRepository, IMapper mapper)
    {
        this.mealsRepository = mealsRepository;
        this.mapper = mapper;
    }



    [HttpGet]
    [Route("meals/{id}")]
    public async Task<ActionResult<List<MealGetDto>>> GetMeals(int id)
    {
        var meals = await this.mealsRepository.GetUserMeals(id);

        if(meals == null) {
            return BadRequest();
        }

        var records = this.mapper.Map<List<MealGetDto>>(meals);
        return Ok(records);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<MealGetDto>> GetMeal(int id)
    {

        var meal = await this.mealsRepository.GetAsync(id);

        if(meal == null)
        {
            return NotFound();
        }

        var record = this.mapper.Map<MealGetDto>(meal);
        return Ok(record);
    }

    [HttpPut]
    [Route("meal/{id}")]
    public async Task<ActionResult<List<Meal>>> ChangeMeal(int id, MealUpdateDto updateMeal)
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

    [HttpPost]
    public async Task<ActionResult<List<Meal>>> AddMeal(MealCreateDto createMeal)
    {
        var meal = this.mapper.Map<Meal>(createMeal);
        await this.mealsRepository.AddAsync(meal);
        return await this.mealsRepository.GetAllAsync();
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult<List<Meal>>> DeleteMeal(int id)
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
