using Data.Services.EntityManager;

using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.ANAKATEGORI.Controllers
{
    [Area("ANAKATEGORI")]
    public class HomeController : Controller
    {
        [Route("/anakategori/{name}")]
        public IActionResult Index(string name)
        {
            var model = MainCategoryManager.Instance.getAllwithProduct1(i => i.Name == name);
            
            if (model!=null)
            {
                return View(model);
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}
