using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DK_JobTGoal.Configuration.Dto;

namespace DK_JobTGoal.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DK_JobTGoalAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
