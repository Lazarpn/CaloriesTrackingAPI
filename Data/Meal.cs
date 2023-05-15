using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaloriesTrackingAPI.Data;

public class Meal
{
    public Guid Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }
    public DateTime Date { get; set; }

    [Range(0, 20000)]
    public int Calories { get; set; }

    public Guid MealsUserId { get; set; }

    [ForeignKey(nameof(MealsUserId))]
    [InverseProperty(nameof(Data.MealsUser.Meals))]
    public MealsUser MealsUser { get; set; }
}
