using Data.Services.EntityManager.WriteSql;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace EcommerceWebSite.Areas.KATEGORI.ViewComponents
{
    public class productSearch:ViewComponent
    {
        public IViewComponentResult Invoke(int id, int price1, int price2, string size, int page=1)
        {
            
            var kacInPage = 10;
            var model = ProductSqlManager.Instance.productItemSearch(id,price1,price2,size).ToPagedList(page,kacInPage);
            if(model.Count != 0)
            {
                ViewBag.aralik = $"{price1.ToString("C0")} - {price2.ToString("C0")} aralığındaki  {model[0].CategoryName} ürünleri";
            }
            else
            {
                ViewBag.aralik = $"{price1.ToString("C0")} - {price2.ToString("C0")} aralığında uygun bir ürün yok";
            }
          
            return View(model);
        }
    }
}
  