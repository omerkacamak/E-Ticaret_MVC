using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.PRODUCT.ViewComponents
{
    public class sizeColorPrice:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var model = ProductItemManager.Instance.GetById(id); // anlik fiyatı veri tabanında güncelliyor çağrıldığı anda
            
            return View(model);
        }
    }
}
