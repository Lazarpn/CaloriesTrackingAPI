using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace CaloriesTrackingAPI.Contracts
{
    public interface IUserRepository
    {
        Task<UserInfoDto> GetUserInfo(string email);
        Task<MealsUser> GetUser(Guid id);
        Task<IdentityResult> ChangeUserInfo(Guid id, string firstName, string lastName);
        Task<UserInfoDto> ChangeCaloriesPreference(UserCaloriesDto userCaloriesDto);
        Task<IdentityResult> UploadPhoto(Guid id, UserPhotoDto userPhotoDto);

    }
}
