using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CrudAbp.Authorization;

namespace CrudAbp
{
    [DependsOn(
        typeof(CrudAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CrudAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CrudAbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CrudAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
