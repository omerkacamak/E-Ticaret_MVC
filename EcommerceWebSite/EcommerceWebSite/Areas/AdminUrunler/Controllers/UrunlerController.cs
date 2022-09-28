using Data.Models;
using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebSite.Areas.AdminUrunler.Controllers
{
    [Area("AdminUrunler")]
    public class UrunlerController : Controller
    {
        ProductItemManager prim = new ProductItemManager(new EfProductItemDal());
        [Route("/admin/urunler")]
        
        public IActionResult Urunler()
        {
            var model = ProductManager.Instance.getAllProduct1(i=>i.ProductID>0);
            return View(model);
        }
        [Route("/admin/urunsil/{id}")]
        public IActionResult UrunSil(int id)
        {
            
            var urun = prim.GetById(id);
           if(urun != null)
            {
                prim.TDelete(urun);
                return Json("Ürün Başarıyla Silindi");
            }
            else
            {
                return Json("Ürün silinemedi");
            }
            
            
        }

        [HttpPost]
        [Route("/admin/updateUrun")]
        public IActionResult UrunGuncelle(ProductItem pri)
        {
            
            prim.TUpdate(pri);
           
            // return Json("basariliii");
            return Redirect("/admin/urunler");
        }

        [Route("/admin/guncelleComp/{id}")]
        public IActionResult urunGuncelleComp(int id)
        {
            return ViewComponent("urunGuncelle", new { id = id });
        }
    }
}
