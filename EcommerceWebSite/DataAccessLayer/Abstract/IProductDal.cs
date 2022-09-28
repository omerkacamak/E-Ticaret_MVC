using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        IEnumerable<Product> haftaninUrunleri();
        List<Product> getAllProduct(Expression<Func<Product, bool>> filter);
        Product  getItemOne(Expression<Func<Product, bool>> filter);
    }
}
