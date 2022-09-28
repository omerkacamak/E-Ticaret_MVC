using Data.Services.EntityManager;
using DataAccessLayer.Connection;
using DataAccessLayer.DataSeeding;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.HOMEPAGE.Controllers
{
    [Area("HOMEPAGE")]
    public class HomeController : Controller
    {
        [Route("/anasayfa")]
        
        public IActionResult Index()
        {
            // DataSeeding.Seed(new Context());
            var model = ProductItemManager.Instance.haftaninUrunleri1();
            return View(model);
        }
        [HttpGet]
        public IActionResult HaftaninUrunleriComp(int id)
        {
            return ViewComponent("haftaninUrunleri",id);
        }
        public IActionResult yeniGelenler(int id)
        {
            return ViewComponent("yenigelenler", new { id = id });
        }
    }
}
