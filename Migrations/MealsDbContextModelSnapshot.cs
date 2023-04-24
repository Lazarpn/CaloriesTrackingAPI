﻿// <auto-generated />
using CaloriesTrackingAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaloriesTrackingAPI.Migrations
{
    [DbContext(typeof(MealsDbContext))]
    partial class MealsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CaloriesTrackingAPI.Data.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 20,
                            Date = "12",
                            Name = "banana",
                            Time = "kad god"
                        },
                        new
                        {
                            Id = 2,
                            Calories = 20,
                            Date = "12",
                            Name = "tost",
                            Time = "kad god"
                        },
                        new
                        {
                            Id = 3,
                            Calories = 20,
                            Date = "12",
                            Name = "sta-god",
                            Time = "kad god"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
