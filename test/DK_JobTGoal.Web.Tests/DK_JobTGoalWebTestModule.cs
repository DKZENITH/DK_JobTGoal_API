using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DK_JobTGoal.EntityFrameworkCore;
using DK_JobTGoal.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DK_JobTGoal.Web.Tests
{
    [DependsOn(
        typeof(DK_JobTGoalWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DK_JobTGoalWebTestModule : AbpModule
    {
        public DK_JobTGoalWebTestModule(DK_JobTGoalEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DK_JobTGoalWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DK_JobTGoalWebMvcModule).Assembly);
        }
    }
}