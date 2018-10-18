using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SunRoseWMS.Controllers
{
    public abstract class SunRoseWMSControllerBase: AbpController
    {
        protected SunRoseWMSControllerBase()
        {
            LocalizationSourceName = SunRoseWMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
