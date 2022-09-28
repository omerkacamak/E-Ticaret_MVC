using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.AdminUrunler.Controllers
{
    [Area("AdminUrunler")]
    public class AnaUrunlerController : Controller
    {
        [Route("/admin/anaurun")]
        public IActionResult AnaUrun()
        {
            var model = ProductManager.Instance.getAllProduct1(i=>i.ProductID>0);
            return View(model);
        }

        public IActionResult anaUrunItemListeleComp(int id)
        {
            return ViewComponent("anaUrunItemListele", new {id=id});
        }
    }
}
