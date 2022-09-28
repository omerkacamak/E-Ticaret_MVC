using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.HOMEPAGE.ViewComponents
{
    public class haftaninUrunleri : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            //var model = ProductManager.Instance.haftaninUrunleri1();
           
            var model = ProductItemManager.Instance.getOneWithProduct1(x=>x.ProductItemID==id);
            
            return View(model);
        }
    }
}
