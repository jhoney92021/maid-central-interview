using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MaidCentralInterview.Authorization;

namespace MaidCentralInterview
{
    [DependsOn(
        typeof(MaidCentralInterviewCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MaidCentralInterviewApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MaidCentralInterviewAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MaidCentralInterviewApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
