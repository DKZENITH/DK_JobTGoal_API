using System.Threading.Tasks;
using Abp.Application.Services;
using DK_JobTGoal.Authorization.Accounts.Dto;

namespace DK_JobTGoal.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
