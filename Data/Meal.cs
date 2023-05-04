using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CaloriesTrackingAPI.Data
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }
        public string Time { get; set; }

        [ForeignKey("MealsUser")]
        public string MealsUserId { get; set; }
        [JsonIgnore]
        public MealsUser MealsUser { get; set; }
    }
}
