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
        

        public async Task<IdentityResult> UploadPhoto(Guid id, UserPhotoDto userPhotoDto)
        {
            var user = await this.context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            byte[] photoBytes = Convert.FromBase64String(userPhotoDto.UserPhoto);

            user.UserPhotoByte = photoBytes;

            var result = await this.context.SaveChangesAsync();
            return new IdentityResult();
        }

        public async Task<MealsUser> GetUser(Guid id)
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



        public async Task<IdentityResult> ChangeUserInfo(Guid id, string firstName, string lastName)
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
