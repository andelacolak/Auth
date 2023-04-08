using Microsoft.AspNetCore.Identity;

namespace Auth.API.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
