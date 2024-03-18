using System.ComponentModel.DataAnnotations;

namespace TaskCopeCommon.Models
{
    internal class AuthenticateRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}