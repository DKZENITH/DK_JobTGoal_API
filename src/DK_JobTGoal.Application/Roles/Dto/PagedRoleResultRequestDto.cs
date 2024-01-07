using Abp.Application.Services.Dto;

namespace DK_JobTGoal.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

