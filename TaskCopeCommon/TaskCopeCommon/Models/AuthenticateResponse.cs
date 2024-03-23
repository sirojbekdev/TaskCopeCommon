using TaskCopeCommon.Entities;

namespace TaskCopeCommon.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            FullName = user.FullName;
            Email = user.Email;
            Role = user.Role.Name;
            Token = token;
        }
    }
}