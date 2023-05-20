using CaloriesTrackingAPI.Contracts;
using CaloriesTrackingAPI.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CaloriesTrackingAPI.Controllers;

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
    [AllowAnonymous]
    [HttpPost]
    [Route("register")]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> Register([FromBody] UserRegisterDto userRegisterDto)
    {
        try
        {
            var authResponse = await this.authManager.Register(userRegisterDto);
            return Ok(authResponse);
        } catch (Exception ex)
        {
            return Unauthorized(ex.Message);
        }
        
    }
    [HttpPost]
    [Route("login")]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> Login([FromBody] UserLoginDto userLoginDto)
    {
        try
        {
            var authResponse = await this.authManager.Login(userLoginDto);
            return Ok(authResponse);
        }
        catch (Exception ex)
        {
            return Unauthorized(ex.Message);
        }
    }


}