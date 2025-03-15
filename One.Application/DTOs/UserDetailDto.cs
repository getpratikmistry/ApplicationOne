using System.ComponentModel.DataAnnotations;

namespace One.Application.Dto
{
    public class UserDetailDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public UserDetailDto()
        {
            Username = string.Empty;
            Password = string.Empty;
            Firstname = string.Empty;
            Lastname = string.Empty;
            Email = string.Empty;
        }
    }
}
