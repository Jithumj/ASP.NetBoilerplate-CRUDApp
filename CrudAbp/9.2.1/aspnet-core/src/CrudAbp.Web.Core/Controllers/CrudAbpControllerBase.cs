using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CrudAbp.Controllers
{
    public abstract class CrudAbpControllerBase: AbpController
    {
        protected CrudAbpControllerBase()
        {
            LocalizationSourceName = CrudAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
