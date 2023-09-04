using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MaidCentralInterview.Configuration;
using MaidCentralInterview.EntityFrameworkCore;
using MaidCentralInterview.Migrator.DependencyInjection;

namespace MaidCentralInterview.Migrator
{
    [DependsOn(typeof(MaidCentralInterviewEntityFrameworkModule))]
    public class MaidCentralInterviewMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MaidCentralInterviewMigratorModule(MaidCentralInterviewEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MaidCentralInterviewMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MaidCentralInterviewConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MaidCentralInterviewMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
