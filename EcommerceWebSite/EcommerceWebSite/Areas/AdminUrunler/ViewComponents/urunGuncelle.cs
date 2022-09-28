using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceWebSite.Areas.AdminUrunler.ViewComponents
{
    public class urunGuncelle : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {

            var model = ProductItemManager.Instance.getWithCat(id);
            // var model = ProductItemManager.Instance.GetById(id);
            List<SelectListItem> urunno = (from x in ProductManager.Instance.GetList()
                                           select new SelectListItem
                                           {
                                               Text = x.ProductName,
                                               Value = x.ProductID.ToString()
                                           }).ToList();
            List<SelectListItem> kategori = (from x in CategoryManager.Instance.GetList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryID.ToString()
                                             }).ToList();
            ViewBag.urunAdi = urunno;
            ViewBag.kategori = kategori;
            ViewData["kategori"] = urunno;

            return View(model);
        }
    }
}
