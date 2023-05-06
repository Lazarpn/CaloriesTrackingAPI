using AutoMapper;
using CaloriesTrackingAPI.Context;
using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CaloriesTrackingAPI.Repository
{
    public class UserRespository : IUserRepository
    {
        private readonly MealsDbContext context;
        private readonly IMapper mapper;

        public UserRespository(MealsDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<List<UserInfoDto>> GetUsers()
        {
            var users = await this.context.Users.ToListAsync();
            if (users == null)
            {
                return null;
            }

            var usersList = this.mapper.Map<List<UserInfoDto>>(users);
            return usersList;

        }

        public async Task<IdentityResult> UploadPhoto(string id, UserPhotoDto userPhotoDto)
        {
            var user = await this.context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }

            user.UserPhoto = userPhotoDto.UserPhoto;

            var result = await this.context.SaveChangesAsync();
            return new IdentityResult();
        }

        public async Task<MealsUser> GetUser(string id)
        {
            var user = await this.context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }

            return user;
        }

        public async Task<UserInfoDto> GetUserInfo(string email)
        {
            var user = await this.context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return null;
            }

            var userInfo = this.mapper.Map<UserInfoDto>(user);

            return userInfo;
        }

        public async Task<UserInfoDto> ChangeCaloriesPreference(UserCaloriesDto userCaloriesDto)
        {
            var user = await this.context.Users.FindAsync(userCaloriesDto.Id);
            if (user == null)
            {
                return null;
            }

            user.CaloriesPreference = userCaloriesDto.CaloriesPreference;
            await this.context.SaveChangesAsync();
            var userInfo = this.mapper.Map<UserInfoDto>(user);

            return userInfo;
        }



        public async Task<IdentityResult> ChangeUserInfo(string id, string firstName, string lastName)
        {
            var user = await this.context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }

            user.FirstName = firstName;
            user.LastName = lastName;


            await this.context.SaveChangesAsync();



            return new IdentityResult();
        }

    }
}
