using Microsoft.AspNetCore.Identity;

namespace aaa.DanceIntegration.Models
{
    public class User: IdentityUser
    {
        public int Year { get; set; }
    }
}
