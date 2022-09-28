using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.AdminUrunler.ViewComponents
{
    public class anaUrunItemListele:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var model=ProductItemManager.Instance.getWithCat(id);
            return View(model);
        }
    }
}
