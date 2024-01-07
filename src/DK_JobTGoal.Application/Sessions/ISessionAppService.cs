using System.Threading.Tasks;
using Abp.Application.Services;
using DK_JobTGoal.Sessions.Dto;

namespace DK_JobTGoal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
