using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Models.User;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace CaloriesTrackingAPI.Contracts
{
    public interface IAuthManager
    {
        Task<AuthResponseDto> Register(UserRegisterDto userDto);
        Task<AuthResponseDto> Login(UserLoginDto userDto);
        Task<UserInfoDto> GetUserInfo(string email);
        Task<MealsUser> GetUser(string id);






    }
}
