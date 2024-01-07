using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DK_JobTGoal.Configuration;
using DK_JobTGoal.Web;

namespace DK_JobTGoal.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DK_JobTGoalDbContextFactory : IDesignTimeDbContextFactory<DK_JobTGoalDbContext>
    {
        public DK_JobTGoalDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DK_JobTGoalDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DK_JobTGoalDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DK_JobTGoalConsts.ConnectionStringName));

            return new DK_JobTGoalDbContext(builder.Options);
        }
    }
}
