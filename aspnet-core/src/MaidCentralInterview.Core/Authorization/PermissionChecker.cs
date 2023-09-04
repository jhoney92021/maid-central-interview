using Abp.Authorization;
using MaidCentralInterview.Authorization.Roles;
using MaidCentralInterview.Authorization.Users;

namespace MaidCentralInterview.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
