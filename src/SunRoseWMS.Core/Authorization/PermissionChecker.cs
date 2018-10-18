using Abp.Authorization;
using SunRoseWMS.Authorization.Roles;
using SunRoseWMS.Authorization.Users;

namespace SunRoseWMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
