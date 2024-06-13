using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace CrudAbp.Web.Views
{
    public abstract class CrudAbpRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CrudAbpRazorPage()
        {
            LocalizationSourceName = CrudAbpConsts.LocalizationSourceName;
        }
    }
}
