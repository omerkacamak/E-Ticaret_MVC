using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.HOMEPAGE.ViewComponents
{
    public class yenigelenler:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            if (id == 1) // yeni gelenler
            {
                var model = ProductItemManager.Instance.yeniGelenler1();
                return View(model);
            }

             if (id == 2) // coksatanlar
            {
                var model = ProductItemManager.Instance.cokSatanlar1();
                return View(model);
            }

            else //anlık satılanlar
            {
                var model = ProductItemManager.Instance.anlikSatilanlar1();
                return View(model);
            }
            
                //return View(null);  
            
                
            

            
        }
    }
}
