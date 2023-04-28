using System.ComponentModel.DataAnnotations;

namespace CaloriesTrackingAPI.Models.Meals
{
    public abstract class BaseMealDto
    {
        [Required]
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }
        public string Time { get; set; }
    }
}
