using Abp.MultiTenancy;
using DK_JobTGoal.Authorization.Users;

namespace DK_JobTGoal.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
