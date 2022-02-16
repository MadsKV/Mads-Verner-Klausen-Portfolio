using Microsoft.AspNetCore.Identity;

namespace LoginAPI.Data
{
    public class ApplicationUser: IdentityUser
    {
        [PersonalData]
        public DateTime CareerStarted { get; set; }
    }
}
