using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DK_JobTGoal.Configuration;
using DK_JobTGoal.EntityFrameworkCore;
using DK_JobTGoal.Migrator.DependencyInjection;

namespace DK_JobTGoal.Migrator
{
    [DependsOn(typeof(DK_JobTGoalEntityFrameworkModule))]
    public class DK_JobTGoalMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public DK_JobTGoalMigratorModule(DK_JobTGoalEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(DK_JobTGoalMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                DK_JobTGoalConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(DK_JobTGoalMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
