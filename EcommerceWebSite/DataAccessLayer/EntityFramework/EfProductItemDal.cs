using Data.Models;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Connection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductItemDal : GenericRepository<ProductItem>, IProductItemDal
    {
        public List<ProductItem> anlikSatilanlar()
        {
            using var c = new Context();
            var orders = c.Orders.FromSqlRaw("Select * from Orders p where convert(date,p.OrderCreateDate) = convert(date, getdate())")
                .Take(6).Include(x => x.OrderDetails).ThenInclude(x => x.ProductItem).ThenInclude(x => x.Product).ToList();

            List<ProductItem> listem = new List<ProductItem>();
            foreach (var item in orders)
            {
                foreach (var item2 in item.OrderDetails)
                {
                    listem.Add(item2.ProductItem);
                }
            }
            return listem;
        }

        public List<ProductItem> cokSatanlar()
        {
            using var c = new Context();
            return c.ProductItems.OrderByDescending(x => x.SatilanMiktar).Take(6).Include(x=>x.Product).ToList();
        }

        public ProductItem getOneWithProduct(Expression<Func<ProductItem, bool>> filter)
        {
            using var c = new Context();
            return c.ProductItems.Where(filter).Include(x => x.Product).ThenInclude(x => x.Category).FirstOrDefault();
        }

        public List<ProductItem> haftaninUrunleri()
        {
            using var c = new Context();
            return c.ProductItems.Where(i=>i.DiscountStatus==true).OrderByDescending(i => i.Discount).Include(x => x.Product).ThenInclude(x => x.Category).Take(3).ToList();
        }

        public List<ProductItem> yeniGelenler()
        {
            using var c = new Context();
            return c.ProductItems.FromSqlRaw("Select * from ProductItems p where convert(date,p.CreatedTime) = convert(date, getdate())").Include(x=>x.Product).ToList();
        }
    }
}
