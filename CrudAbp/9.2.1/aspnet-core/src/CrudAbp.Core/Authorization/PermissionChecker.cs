using Abp.Authorization;
using CrudAbp.Authorization.Roles;
using CrudAbp.Authorization.Users;

namespace CrudAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
