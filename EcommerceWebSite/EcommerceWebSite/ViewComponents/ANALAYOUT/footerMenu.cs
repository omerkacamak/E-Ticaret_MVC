using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EcommerceWebSite.ViewComponents.ANALAYOUT
{
    public class footerMenu:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = MainCategoryManager.Instance.GetList();
           var about=  AboutManager.Instance.GetById(1);
            TempData["about"] = about.Description;
            return View(model);
        }
    }
}
