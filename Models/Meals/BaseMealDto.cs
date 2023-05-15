using System.ComponentModel.DataAnnotations;

namespace CaloriesTrackingAPI.Models.Meals
{
    public abstract class BaseMealDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime Date { get; set; }

        [Range(0, 20000)]
        public int Calories { get; set; }
    }
}
