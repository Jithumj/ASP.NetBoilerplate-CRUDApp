using Abp.Application.Services;
using CrudAbp.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CrudAbp.CrudTable;
using CrudAbp.CrudTable.Dto;
namespace CrudAbp.Web.Controllers
{
    public class CrudView : CrudAbpControllerBase
    {
        private readonly ICrudTableAppService _crudAppService;
        public CrudView(ICrudTableAppService crudAppService)
        {
            _crudAppService = crudAppService;
        }

        public async  Task<IActionResult> Index()
        {
            return View("~/Views/CrudView/Index.cshtml");
        }
        //validation for insertion
       
        //Inserting data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CrudTableDto input)
        {
            if(ModelState.IsValid)
            {
                var crudTableDto = new CrudTableDto
                {

                    Name = input.Name,
                    Quote = input.Quote,
                };
            await _crudAppService.Create(crudTableDto);
             

            }
  
            return View("~/Views/CrudView/Index.cshtml");
        }

        //Getting data from table to list in a table
        [HttpGet]
        public async Task<ActionResult> ShowQuotes()
        {
            var showQuotes=await _crudAppService.GetAllAsync(); 
            return View(showQuotes);
        }
        //get the data to show in a form to edit
        [HttpPost]
        public async Task<ActionResult>UpdateQuotes(int id)
        {
            var quotes=await _crudAppService.GetAsync(id);
            var editview=ObjectMapper.Map<CrudTableDto>(quotes);    
            return View(editview);
        }

        //Edit quotes and name
        [HttpGet]
        public async Task<ActionResult> EditQuotes(CrudTableDto input)
        {
            await _crudAppService.UpdateAsync(input);
            return RedirectToAction("ShowQuotes", "CrudView");
        }
        [HttpPost]
        public async Task<ActionResult> DeleteQuotes(int id)
        {
            await _crudAppService.DeleteAsync(id);
            return RedirectToAction("ShowQuotes", "CrudView");
        }


    }
}
