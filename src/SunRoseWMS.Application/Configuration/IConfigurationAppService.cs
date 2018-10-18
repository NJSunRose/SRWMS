using System.Threading.Tasks;
using SunRoseWMS.Configuration.Dto;

namespace SunRoseWMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
