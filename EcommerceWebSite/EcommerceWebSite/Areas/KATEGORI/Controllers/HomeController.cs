using Data.Models;
using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EcommerceWebSite.Areas.KATEGORI.Controllers
{
    [Area("KATEGORI")]
    public class HomeController : Controller
    {


        [Route("/kategori/{name}")]
        
        public IActionResult Index(string name)
        {
           

            var model = CategoryManager.Instance.GetOne1(i => i.CategoryName == name);
            
            if(model != null)
            {
                var ustkategori = MainCategoryManager.Instance.GetOne1(i => i.MainCategoryID == model.MainCategoryID);
                ViewBag.ustKategori = ustkategori.Name;
                return View(model);
            }

            else
            {
                return NotFound();
            }
            
        }

        public IActionResult urunlerComp(int id,int page)
        {
            return ViewComponent("urunler", new{id=id ,page=page});
        }
        public IActionResult productSearch(int id, int price1, int price2,  int page, string size="" )
        {
            return ViewComponent("productSearch", new { id = id, price1 = price1, price2=price2, size=size,page=page });
        }
     
    }
}
