using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CrudAbp.Configuration;

namespace CrudAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(CrudAbpWebCoreModule))]
    public class CrudAbpWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CrudAbpWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CrudAbpWebHostModule).GetAssembly());
        }
    }
}
