using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MaidCentralInterview.EntityFrameworkCore;
using MaidCentralInterview.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MaidCentralInterview.Web.Tests
{
    [DependsOn(
        typeof(MaidCentralInterviewWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MaidCentralInterviewWebTestModule : AbpModule
    {
        public MaidCentralInterviewWebTestModule(MaidCentralInterviewEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MaidCentralInterviewWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MaidCentralInterviewWebMvcModule).Assembly);
        }
    }
}