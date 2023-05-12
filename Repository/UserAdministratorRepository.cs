using AutoMapper;
using CaloriesTrackingAPI.Context;
using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Data;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CaloriesTrackingAPI.Repository
{
    public class UserAdministratorRepository: IUserAdministratorRepository
    {
        private readonly MealsDbContext context;
        private readonly IMapper mapper;
        private readonly UserManager<MealsUser> userManager;

        public UserAdministratorRepository(MealsDbContext context, IMapper mapper, UserManager<MealsUser> userManager)
        {
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
        }
        public async Task<List<UserInfoDto>> GetUsers()
        {
            var users = await this.userManager.GetUsersInRoleAsync("user");
            if (users == null)
            {
                return null;
            }

            var usersList = this.mapper.Map<List<UserInfoDto>>(users);
            return usersList;

        }

        public async Task<IdentityResult> ChangeUser(ManagerUserUpdateDto managerUserUpdateDto)
        {
            var user = await this.userManager.FindByIdAsync(managerUserUpdateDto.Id);
            if (user == null)
            {
                return null;
            }

            this.mapper.Map(managerUserUpdateDto, user);

            var result = await this.userManager.UpdateAsync(user);


            if (result.Succeeded)
            {
                return result;
            }

            return result;



        }

        public async Task<IdentityResult> DeleteUser(string email)
        {

            var user = await this.userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return null;
            }
            var result = await this.userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return result;
            }

            return result;
        }
    }
}
