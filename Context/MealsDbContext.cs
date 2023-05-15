using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Data.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CaloriesTrackingAPI.Context;

public class MealsDbContext : IdentityDbContext<MealsUser, IdentityRole<Guid>, Guid>
{
    public DbSet<Meal> Meals { get; set; }

    public MealsDbContext(DbContextOptions options) : base(options)
    {
        Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new MealsConfiguration());
    }
}
