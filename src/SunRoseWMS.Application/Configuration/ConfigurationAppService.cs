using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SunRoseWMS.Configuration.Dto;

namespace SunRoseWMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SunRoseWMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
