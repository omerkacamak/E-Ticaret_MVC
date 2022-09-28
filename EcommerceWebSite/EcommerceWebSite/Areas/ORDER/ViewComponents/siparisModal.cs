using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.ORDER.ViewComponents
{
    public class siparisModal:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var model = OrderDetailManager.Instance.getListWithProducts1(i => i.OrderID == id);
            return View(model);
        }
    }
}
