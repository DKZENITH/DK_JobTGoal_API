using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DK_JobTGoal.Authorization;

namespace DK_JobTGoal
{
    [DependsOn(
        typeof(DK_JobTGoalCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DK_JobTGoalApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DK_JobTGoalAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DK_JobTGoalApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
