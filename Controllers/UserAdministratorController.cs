using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaloriesTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserAdministratorController : ControllerBase
    {
      
        private readonly IUserAdministratorRepository userAdministratorRepository;

        

        public UserAdministratorController( IUserAdministratorRepository userAdministratorRepository)
        {
           
            this.userAdministratorRepository = userAdministratorRepository;
        }

        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<UserInfoDto>>> GetUsers()
        {
            var users = await this.userAdministratorRepository.GetUsers();
            if (users == null)
            {
                return NotFound();
            }

            return users;
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> ChangeUser(string id, ManagerUserUpdateDto managerUserUpdateDto)
        {
            var userResponse = await this.userAdministratorRepository.ChangeUser(managerUserUpdateDto);
            if (userResponse == null)
            {
                return BadRequest();
            }

            return Ok(userResponse);
        }

        [HttpDelete]
        [Route("{email}")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteUser(string email)
        {
            var authResponse = await this.userAdministratorRepository.DeleteUser(email);
            if (authResponse == null)
            {
                return BadRequest();
            }

            return Ok(authResponse);
        }
    }
}
