using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        IEnumerable<Product> haftaninUrunleri1();
        List<Product> getAllProduct1(Expression<Func<Product, bool>> filter);
        Product getItemOne1(Expression<Func<Product, bool>> filter);
    }
}
