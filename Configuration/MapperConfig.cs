using AutoMapper;
using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Models.Meals;
using CaloriesTrackingAPI.Models.Users;

namespace CaloriesTrackingAPI.Configuration;

public class MapperConfig: Profile
{
    public MapperConfig()
    {
        CreateMap<MealCreateDto, Meal>().ReverseMap();
        CreateMap<MealGetDto, Meal>().ReverseMap();
        CreateMap<MealUpdateDto, Meal>().ReverseMap();

        CreateMap<UserRegisterDto , MealsUser>().ReverseMap();
        CreateMap<UserLoginDto, MealsUser>().ReverseMap();
        CreateMap<UserRegisterDto, UserLoginDto>().ReverseMap();
        CreateMap<UserInfoDto, MealsUser>().ReverseMap();
        CreateMap<UserCaloriesDto, MealsUser>().ReverseMap();
        CreateMap<UserCaloriesDto, UserInfoDto>().ReverseMap();
        CreateMap<UserPhotoDto, MealsUser>().ReverseMap();







    }

}
