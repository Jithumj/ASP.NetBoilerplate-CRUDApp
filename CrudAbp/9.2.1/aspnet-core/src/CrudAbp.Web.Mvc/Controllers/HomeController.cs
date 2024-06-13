using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CrudAbp.Controllers;

namespace CrudAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CrudAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
