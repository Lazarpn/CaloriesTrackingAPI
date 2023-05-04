﻿using Microsoft.EntityFrameworkCore;
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
                //MealsUserId = "1",
            }, new Meal
            {
                Id = 2,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                //MealsUserId = "1",

            }, new Meal
            {
                Id = 3,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                //MealsUserId = "1",

            }, new Meal
            {
                Id = 4,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                //MealsUserId = "4",

            }, new Meal
            {
                Id = 5,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                //MealsUserId = "4",

            }, new Meal
            {
                Id = 6,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                //MealsUserId = "4",

            }, new Meal
            {
                Id = 7,
                Name = "Jamaica",
                Date = "bas",
                Calories = 150,
                Time = "bla",
                //MealsUserId = "4",

            }
            );



        }
    }
}