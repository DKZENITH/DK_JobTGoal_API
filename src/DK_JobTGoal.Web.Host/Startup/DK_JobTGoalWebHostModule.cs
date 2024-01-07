using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DK_JobTGoal.Configuration;

namespace DK_JobTGoal.Web.Host.Startup
{
    [DependsOn(
       typeof(DK_JobTGoalWebCoreModule))]
    public class DK_JobTGoalWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DK_JobTGoalWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DK_JobTGoalWebHostModule).GetAssembly());
        }
    }
}
