using AutoMapper;
using CaloriesTrackingAPI.Context;
using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace CaloriesTrackingAPI.Repository
{
    public class UserAdministratorRepository: IUserAdministratorRepository
    {
        private readonly MealsDbContext context;
        private readonly IMapper mapper;

        public UserAdministratorRepository(MealsDbContext context, IMapper mapper)
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
    }
}
