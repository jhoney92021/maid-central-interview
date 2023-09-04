using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MaidCentralInterview.Configuration;

namespace MaidCentralInterview.Web.Host.Startup
{
    [DependsOn(
       typeof(MaidCentralInterviewWebCoreModule))]
    public class MaidCentralInterviewWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MaidCentralInterviewWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MaidCentralInterviewWebHostModule).GetAssembly());
        }
    }
}
