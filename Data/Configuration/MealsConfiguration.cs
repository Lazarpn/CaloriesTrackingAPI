using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace CaloriesTrackingAPI.Data.Configuration
{
    public class MealsConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(new Meal
            {
                Id = 1,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                MealsUserId = "1970b77a-defb-4710-a942-8062345d4a34",
            }, new Meal
            {
                Id = 2,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                MealsUserId = "1970b77a-defb-4710-a942-8062345d4a34",

            }, new Meal
            {
                Id = 3,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                MealsUserId = "1970b77a-defb-4710-a942-8062345d4a34",

            }, new Meal
            {
                Id = 4,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                MealsUserId = "61226191-d59e-42fd-ac75-c8c66dc4f2b9",

            }, new Meal
            {
                Id = 5,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                MealsUserId = "61226191-d59e-42fd-ac75-c8c66dc4f2b9",

            }, new Meal
            {
                Id = 6,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                MealsUserId = "61226191-d59e-42fd-ac75-c8c66dc4f2b9",

            }, new Meal
            {
                Id = 7,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                MealsUserId = "61226191-d59e-42fd-ac75-c8c66dc4f2b9",

            }
            );



        }
    }
}