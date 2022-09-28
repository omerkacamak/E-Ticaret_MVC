using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Controllers
{
    public class ErrorPageController : Controller
    {
        [Route("/e_rror")]
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
