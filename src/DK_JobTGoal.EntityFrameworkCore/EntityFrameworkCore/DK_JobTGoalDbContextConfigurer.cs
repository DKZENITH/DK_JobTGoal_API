using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DK_JobTGoal.EntityFrameworkCore
{
    public static class DK_JobTGoalDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DK_JobTGoalDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DK_JobTGoalDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
