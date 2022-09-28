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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> getAllProduct(Expression<Func<Product, bool>> filter)
        {
            using var c = new Context();
            return c.Products.Where(filter).Include(i=>i.Category).ThenInclude(x=>x.AnaKategori).Include(i=>i.ProductItems).ToList();
        }

        public Product getItemOne(Expression<Func<Product, bool>> filter)
        {
            using var c = new Context();
            return c.Products.Where(filter).Include(i => i.Category).Include(i => i.ProductItems).FirstOrDefault();
        }

        public IEnumerable<Product> haftaninUrunleri()
        {
            using var c = new Context();
            return c.Products.Include(i => i.Category).Take(3).ToList();
                
        }
    }
}
