using CaloriesTrackingAPI.Models.Users;

namespace CaloriesTrackingAPI.Models.User;

public class AuthResponseDto

{
    public Guid UserId { get; set; }
    public string Token { get; set; }
    public UserInfoDto UserInfo { get; set; }
}