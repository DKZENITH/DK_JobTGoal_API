using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using DK_JobTGoal.MultiTenancy;

namespace DK_JobTGoal.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
