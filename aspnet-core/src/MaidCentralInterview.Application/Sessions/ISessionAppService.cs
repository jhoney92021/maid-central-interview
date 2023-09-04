using System.Threading.Tasks;
using Abp.Application.Services;
using MaidCentralInterview.Sessions.Dto;

namespace MaidCentralInterview.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
