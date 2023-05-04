using CaloriesTrackingAPI.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CaloriesTrackingAPI.Models.Meals
{
    public class MealCreateDto: BaseMealDto
    {
        //[JsonIgnore]
        public string MealsUserId { get; set; }
        //public MealsUser MealsUser { get; set; }
    }
}
