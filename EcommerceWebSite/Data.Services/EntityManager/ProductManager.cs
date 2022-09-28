using Data.Models;
using Data.Services.Abstract;
using Data.Services.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.EntityManager
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        public static ProductManager Instance => new ProductManager(new EfProductDal());
        IProductDal productDal;
        public ProductManager(IGenericDal<Product> genericDal) : base(genericDal)
        {
            productDal = new EfProductDal();
        }

        public IEnumerable<Product> haftaninUrunleri1()
        {
            return productDal.haftaninUrunleri();
        }

        public List<Product> getAllProduct1(Expression<Func<Product, bool>> filter)
        {
            return productDal.getAllProduct(filter);
        }

        public Product getItemOne1(Expression<Func<Product, bool>> filter)
        {
            return productDal.getItemOne(filter);
        }
    }
}
