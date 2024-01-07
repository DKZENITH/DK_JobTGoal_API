using System.Threading.Tasks;
using DK_JobTGoal.Configuration.Dto;

namespace DK_JobTGoal.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
