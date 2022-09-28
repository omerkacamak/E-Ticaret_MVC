using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EcommerceWebSite.Areas.HOMEPAGE.ViewComponents
{
    public class SliderBar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = SliderBarsManager.Instance.GetListAll(i => i.LocationPage == "anasayfa");
            return View(model);
        }
    }
}
