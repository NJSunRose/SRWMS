using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SunRoseWMS.Configuration;

namespace SunRoseWMS.Web.Host.Startup
{
    [DependsOn(
       typeof(SunRoseWMSWebCoreModule))]
    public class SunRoseWMSWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SunRoseWMSWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SunRoseWMSWebHostModule).GetAssembly());
        }
    }
}
