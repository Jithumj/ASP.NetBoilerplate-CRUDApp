using Abp.AspNetCore.Mvc.ViewComponents;

namespace CrudAbp.Web.Views
{
    public abstract class CrudAbpViewComponent : AbpViewComponent
    {
        protected CrudAbpViewComponent()
        {
            LocalizationSourceName = CrudAbpConsts.LocalizationSourceName;
        }
    }
}
