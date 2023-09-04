using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MaidCentralInterview.Roles.Dto;
using MaidCentralInterview.Users.Dto;

namespace MaidCentralInterview.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
