using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace CaloriesTrackingAPI.Contracts
{
    public interface IUserRepository
    {
        Task<UserInfoDto> GetUserInfo(string email);
        Task<MealsUser> GetUser(string id);
        Task<IdentityResult> ChangeUserInfo(string id, string firstName, string lastName);
        Task<UserInfoDto> ChangeCaloriesPreference(UserCaloriesDto userCaloriesDto);
        Task<IdentityResult> UploadPhoto(string id, UserPhotoDto userPhotoDto);

        Task<List<UserInfoDto>> GetUsers();
    }
}
