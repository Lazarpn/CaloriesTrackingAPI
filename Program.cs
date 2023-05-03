using CaloriesTrackingAPI.Configuration;
using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Repository;
using CaloriesTrackingAPI.Configuration;
using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using CaloriesTrackingAPI.Context;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace HotelListingApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        var connectionString = builder.Configuration.GetConnectionString("HotelListingDbConnectionString");
        builder.Services.AddDbContext<MealsDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", b => b.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
        });

       

        builder.Services.AddAutoMapper(typeof(MapperConfig));

        //builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRespository<>));
        builder.Services.AddScoped<IMealsRepository, MealsRepository>();

        builder.Services.AddIdentityCore<MealsUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<MealsDbContext>();
        builder.Services.AddScoped<IAuthManager, AuthManager>();

        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
                ValidAudience = builder.Configuration["JwtSettings:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"])),
            };
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }


        app.UseHttpsRedirection();

        app.UseCors("AllowAll");



        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}