using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.ADMIN.Controllers
{
    [Area("AdminDash")]
    public class DashboardController : Controller
    {
        [Route("/admin")]
        
        public IActionResult Dashboard()
        {
            CustomerManager cm = new CustomerManager(new EfCustomerDal());
            ViewBag.toplamMusteri = ProductItemManager.Instance.ToplamSayi1();
            ViewBag.toplamKullanici = cm.ToplamSayi1();
            ViewBag.bugunMusteri = cm.CreatedToday1("CreatedTime").Count;
            ViewBag.online = GirisZamaniManager.Instance.GetListAll(i => i.Status == true).Count;
            

            return View();
        }
    }
}
