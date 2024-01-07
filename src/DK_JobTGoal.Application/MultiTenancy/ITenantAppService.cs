using Abp.Application.Services;
using DK_JobTGoal.MultiTenancy.Dto;

namespace DK_JobTGoal.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

