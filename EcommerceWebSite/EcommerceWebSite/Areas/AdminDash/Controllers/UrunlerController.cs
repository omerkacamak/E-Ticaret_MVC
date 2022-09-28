using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.ADMIN.Controllers
{
    
    public class UrunlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
