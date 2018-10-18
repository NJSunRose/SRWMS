using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SunRoseWMS.Authorization;

namespace SunRoseWMS
{
    [DependsOn(
        typeof(SunRoseWMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SunRoseWMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SunRoseWMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SunRoseWMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
