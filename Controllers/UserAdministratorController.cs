using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Migrations;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaloriesTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UserAdministratorController : ControllerBase
    {
        private readonly IAuthManager authManager;
        private readonly IUserAdministratorRepository userAdministratorRepository;

        //api/Account/${id}
        // ZA MANAGER-A

        public UserAdministratorController(IAuthManager authManager, IUserAdministratorRepository userAdministratorRepository)
        {
            this.authManager = authManager;
            this.userAdministratorRepository = userAdministratorRepository;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("all")]
        //[Authorize(Roles = "Administrator")]
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

        [AllowAnonymous]
        [HttpPut]
        [Route("{id}")]
        //[Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> ChangeUser(string id, UserInfoDto userInfoDto)
        {
            var authResponse = await this.authManager.ChangeUser(userInfoDto);
            if (authResponse == null)
            {
                return BadRequest();
            }

            return Ok(authResponse);
        }
        //api/Account/register
        // ZA MANAGER-A
        [AllowAnonymous]
        [HttpDelete]
        [Route("{email}")]
        //[Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteUser(string email)
        {
            var authResponse = await this.authManager.DeleteUser(email);
            if (authResponse == null)
            {
                return BadRequest();
            }

            return Ok(authResponse);
        }
    }
}
