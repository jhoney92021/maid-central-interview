using Abp.Application.Services;
using MaidCentralInterview.MultiTenancy.Dto;

namespace MaidCentralInterview.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

