using Data.Services.EntityManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EcommerceWebSite.Areas.ORDER.Controllers
{
    [Area("ORDER")]
    public class SiparislerimController : Controller
    {
        [Authorize]
        [Route("/siparislerim")]
        public IActionResult Siparislerim()
        {
            
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);
            var model = OrderManager.Instance.GetListAll(i => i.CustomerID == userid);
            return View(model);
        }

        public IActionResult siparisModal(int id)
        {
            return ViewComponent("siparisModal", new {id=id});
        }
    }

    
}
