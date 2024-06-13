using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CrudAbp.Configuration.Dto;

namespace CrudAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CrudAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
