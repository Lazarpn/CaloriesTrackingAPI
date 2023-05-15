using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace CaloriesTrackingAPI.Contracts;

public interface IUserAdministratorRepository
{
    Task<List<UserInfoDto>> GetUsers();
    Task<IdentityResult> ChangeUser(ManagerUserUpdateDto userInfoDto);
    Task<IdentityResult> DeleteUser(string email);
}
