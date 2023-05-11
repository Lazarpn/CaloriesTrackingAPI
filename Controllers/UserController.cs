using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaloriesTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        [Route("all")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<UserInfoDto>>> GetUsers()
        {
            var users = await this.userRepository.GetUsers();
            if (users == null)
            {
                return NotFound();
            }

            return users;
        }

        [HttpPut]
        [Route("calories/{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> ChangeCaloriesPreference(string id, UserCaloriesDto userCaloriesDto)
        {
            if (id != userCaloriesDto.Id)
            {
                return BadRequest();
            }
            var result = await this.userRepository.ChangeCaloriesPreference(userCaloriesDto);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }




        [HttpPut]
        [Route("photo/{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UploadPhoto(string id, UserPhotoDto userPhotoDto)
        {
            if (id != userPhotoDto.Id)
            {
                return BadRequest();
            }
            var result = await this.userRepository.UploadPhoto(id, userPhotoDto);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }




        [HttpPut]
        [Route("{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> ChangeUserInfo(string id, UserUpdateDto userUpdate)
        {
            if (id != userUpdate.Id)
            {
                return BadRequest();
            }
            var result = await this.userRepository.ChangeUserInfo(id, userUpdate.FirstName, userUpdate.LastName);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        //api/Account/email
        [HttpGet]
        [Route("{email}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UserInfoDto>> GetUserInfo(string email)
        {
            var user = await this.userRepository.GetUserInfo(email);

            if (user == null)
            {
                return BadRequest();
            }

            return Ok(user);
        }
    }
}
