using Abp.Application.Services.Dto;

namespace MaidCentralInterview.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

