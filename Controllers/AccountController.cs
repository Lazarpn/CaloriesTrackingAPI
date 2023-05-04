using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Models.User;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaloriesTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthManager authManager;

        public AccountController(IAuthManager authManager)
        {
            this.authManager = authManager;
        }


        //api/Account/register
        [HttpPost]
        [Route("userInfo")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UserInfoDto>> GetUserInfo(string email)
        {
            var user = await this.authManager.GetUserInfo(email);

            if (user == null)
            {
                return BadRequest();
            }

            return Ok(user);
        }

        //api/Account/register
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Register([FromBody] UserRegisterDto userRegisterDto)
        {
            var authResponse = await this.authManager.Register(userRegisterDto);
            if (authResponse == null)
            {
                return Unauthorized();
            }

            return Ok(authResponse);
        }
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Login([FromBody] UserLoginDto userLoginDto)
        {
            var authResponse = await this.authManager.Login(userLoginDto);
            if (authResponse == null)
            {
                return Unauthorized();
            }

            return Ok(authResponse);
        }


    }
}