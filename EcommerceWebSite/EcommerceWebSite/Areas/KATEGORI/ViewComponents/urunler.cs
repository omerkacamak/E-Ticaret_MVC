using Data.Services.EntityManager;
using Data.Services.EntityManager.WriteSql;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace EcommerceWebSite.Areas.KATEGORI.ViewComponents
{
    public class urunler:ViewComponent
    {
        public IViewComponentResult Invoke(int id,int page=1) // id= kategori id alır ana index sayfasından.
        {
            var kacPage = 8;

            //var model = ProductManager.Instance.getAllProduct1(i => i.CategoryID == id).ToPagedList(page,kacPage);
            var model = ProductSqlManager.Instance.productItemSorgu(id).ToPagedList(page,kacPage);
            return View(model);       
        }
    }
}
