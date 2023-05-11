using CaloriesTrackingAPI.Models.Users;

namespace CaloriesTrackingAPI.Contracts
{
    public interface IUserAdministratorRepository
    {
        Task<List<UserInfoDto>> GetUsers();

    }
}
