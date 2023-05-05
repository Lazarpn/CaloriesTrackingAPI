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

        [HttpPut]
        [Route("calories/{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> ChangeCaloriesPreference(string id, UserCaloriesDto userCaloriesDto)
        {
            if (id != userCaloriesDto.Id)
            {
                return BadRequest();
            }
            var result = await this.authManager.ChangeCaloriesPreference(userCaloriesDto);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

       


        [HttpPut]
        [Route("photo/{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UploadPhoto(string id, UserPhotoDto userPhotoDto)
        {
            if (id != userPhotoDto.Id)
            {
                return BadRequest();
            }
            var result = await this.authManager.UploadPhoto(id, userPhotoDto);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }


     

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> ChangeUserInfo(string id, UserUpdateDto userUpdate)
        {
            if(id != userUpdate.Id)
            {
                return BadRequest();
            }
            var result = await this.authManager.ChangeUserInfo(id, userUpdate.FirstName, userUpdate.LastName);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        //api/Account/email
        [HttpGet]
        [Route("{email}")]
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