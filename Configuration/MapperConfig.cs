using AutoMapper;
using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Models.Meals;

namespace CaloriesTrackingAPI.Configuration;

public class MapperConfig: Profile
{
    public MapperConfig()
    {
        CreateMap<MealCreateDto, Meal>().ReverseMap();
        CreateMap<MealGetDto, Meal>().ReverseMap();
        CreateMap<MealUpdateDto, Meal>().ReverseMap();

    }

}
