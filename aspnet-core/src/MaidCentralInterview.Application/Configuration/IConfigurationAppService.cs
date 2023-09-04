using System.Threading.Tasks;
using MaidCentralInterview.Configuration.Dto;

namespace MaidCentralInterview.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
