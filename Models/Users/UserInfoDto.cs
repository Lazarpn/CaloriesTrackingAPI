namespace CaloriesTrackingAPI.Models.Users
{
    public class UserInfoDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CaloriesPreference { get; set; } = 0;

        public byte[] UserPhotoByte { get; set; }



    }
}
