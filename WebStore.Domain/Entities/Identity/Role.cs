using Microsoft.AspNetCore.Identity;

namespace WebStore.Domain.Entities.Identity
{
    public class Role : IdentityRole
    {
        public const string Administrator = "Administrators";
        public const string Moderator = "Moderator";
        public const string User = "Users";
    }
}