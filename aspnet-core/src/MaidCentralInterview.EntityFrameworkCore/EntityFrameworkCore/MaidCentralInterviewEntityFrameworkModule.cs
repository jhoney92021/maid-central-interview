using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using MaidCentralInterview.EntityFrameworkCore.Seed;

namespace MaidCentralInterview.EntityFrameworkCore
{
    [DependsOn(
        typeof(MaidCentralInterviewCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class MaidCentralInterviewEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<MaidCentralInterviewDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        MaidCentralInterviewDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        MaidCentralInterviewDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MaidCentralInterviewEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
