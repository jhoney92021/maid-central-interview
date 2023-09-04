using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MaidCentralInterview.Configuration.Dto;

namespace MaidCentralInterview.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MaidCentralInterviewAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
