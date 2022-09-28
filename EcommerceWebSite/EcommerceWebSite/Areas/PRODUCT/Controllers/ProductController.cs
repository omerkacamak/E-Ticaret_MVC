using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.PRODUCT.Controllers
{
    [Area("PRODUCT")]
    public class ProductController : Controller
    {
        [Route("/urun/{name}")]
        public IActionResult Product(string name)
        {
            var model = ProductManager.Instance.getItemOne1(i=>i.ProductName==name);

            if(model != null)
            {
                //var options = ProductOptionsManager.Instance.getOptions1(i => i.ProductID == model.ProductID);
                //var opt = ProOptStokManager.Instance.getOptValue1(i => i.ProductID == model.ProductID);
                //TempData["productOptions"] = opt;
                return View(model);
            }

            else
            {
                return NotFound();
            }
        }
        public IActionResult changePriceComp(int id)
        {
            return ViewComponent("sizeColorPrice",id);
        }
    }
}
