using Microsoft.AspNetCore.Identity;

namespace WebStore.Domain.Entities.Identity
{
    public class User : IdentityUser
    {
        public const string Administrator = "Admin";
        public const string DefaultAdminPassword = "AdminPAssword"; 
        public const string Moderator = "Moder";
        public const string DefaultModerPassword = "ModerPAssword";
    }
}
