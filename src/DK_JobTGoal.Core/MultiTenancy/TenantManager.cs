using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using DK_JobTGoal.Authorization.Users;
using DK_JobTGoal.Editions;

namespace DK_JobTGoal.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
