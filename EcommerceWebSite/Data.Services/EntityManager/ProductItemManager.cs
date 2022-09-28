using Data.Models;
using Data.Services.Abstract;
using Data.Services.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Connection;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.EntityManager
{
    public class ProductItemManager : GenericManager<ProductItem>, IProductItemService
    {
        public static ProductItemManager Instance => new ProductItemManager(new EfProductItemDal());
        IProductItemDal productItemDal;

        
        public ProductItemManager(IGenericDal<ProductItem> genericDal) : base(genericDal)
        {
            productItemDal = new EfProductItemDal();
        }

        public ProductItem getWithCat(int id)
        {
            using var c = new Context();
            return c.ProductItems.Include(z => z.Product).ThenInclude(x => x.Category).FirstOrDefault(x => x.ProductItemID == id);
        }
        public List<ProductItem> haftaninUrunleri1()
        {
            return productItemDal.haftaninUrunleri();
        }

        public ProductItem getOneWithProduct1(Expression<Func<ProductItem, bool>> filter)
        {
            return productItemDal.getOneWithProduct(filter);
        }

        public List<ProductItem> yeniGelenler1()
        {
            return productItemDal.yeniGelenler();
        }

        public List<ProductItem> cokSatanlar1()
        {
            return productItemDal.cokSatanlar();
        }

        public List<ProductItem> anlikSatilanlar1()
        {
            return productItemDal.anlikSatilanlar();
        }
    }
}
