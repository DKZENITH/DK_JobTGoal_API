using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DK_JobTGoal.Authorization.Roles;
using DK_JobTGoal.Authorization.Users;
using DK_JobTGoal.MultiTenancy;

namespace DK_JobTGoal.EntityFrameworkCore
{
    public class DK_JobTGoalDbContext : AbpZeroDbContext<Tenant, Role, User, DK_JobTGoalDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DK_JobTGoalDbContext(DbContextOptions<DK_JobTGoalDbContext> options)
            : base(options)
        {
        }
    }
}
