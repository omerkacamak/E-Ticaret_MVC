using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EcommerceWebSite.Areas.HOMEPAGE.ViewComponents
{
    public class kategorilerden3u : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = MainCategoryManager.Instance.getAllwithCategory1();
            return View(model);
        }
    }
}
