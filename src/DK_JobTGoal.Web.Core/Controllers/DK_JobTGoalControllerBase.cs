using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DK_JobTGoal.Controllers
{
    public abstract class DK_JobTGoalControllerBase: AbpController
    {
        protected DK_JobTGoalControllerBase()
        {
            LocalizationSourceName = DK_JobTGoalConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
