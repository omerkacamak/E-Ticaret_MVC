using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EcommerceWebSite.ViewComponents.ANALAYOUT
{
    public class topMenu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = MainCategoryManager.Instance.getAllwithCategory1(); // alt kategorilerle beraber geliyor

            if (User.Identity.IsAuthenticated)
            {
                var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
                var userid = Convert.ToInt32(user);
                var sepet = ShoppingCartManager.Instance.getOneOnlyItems1(i => i.CustomerID == userid && i.Status == true);
                if (sepet != null)
                {
                    ViewBag.sepet = sepet.ShoppingCartItems.Count;
                    ViewBag.sepetPrice = sepet.totalPrice.ToString("C0");
                }

            }

            return View(model);
        }
    }
}
