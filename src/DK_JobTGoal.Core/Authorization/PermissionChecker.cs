using Abp.Authorization;
using DK_JobTGoal.Authorization.Roles;
using DK_JobTGoal.Authorization.Users;

namespace DK_JobTGoal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
