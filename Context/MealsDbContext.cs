using CaloriesTrackingAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace CaloriesTrackingAPI.Context;

public class MealsDbContext : DbContext
{
    public MealsDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Meal> Meals { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Meal>().HasData(
            new Meal
            {
                Id = 1,
                Name = "banana",
                Date = "12",
                Calories = 20,
                Time = "kad god"
            },
        new Meal
        {
            Id = 2,
            Name = "tost",
            Date = "12",
            Calories = 20,
            Time = "kad god"
        },
        new Meal
        {
            Id = 3,
            Name = "sta-god",
            Date = "12",
            Calories = 20,
            Time = "kad god"
        }

            );
    }


}
