using System.ComponentModel.DataAnnotations.Schema;

namespace CaloriesTrackingAPI.Data
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }
        public string Time { get; set; }

        [ForeignKey(nameof(MealsUserId))]
        public int MealsUserId { get; set; }
        public MealsUser MealsUser { get; set; }
    }
}
