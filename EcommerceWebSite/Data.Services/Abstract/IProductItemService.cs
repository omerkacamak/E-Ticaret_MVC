using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Abstract
{
    public interface IProductItemService : IGenericService<ProductItem>
    {
       List<ProductItem> haftaninUrunleri1();
        ProductItem getOneWithProduct1(Expression<Func<ProductItem, bool>> filter);
        List<ProductItem> yeniGelenler1();
        List<ProductItem> cokSatanlar1();
        List<ProductItem> anlikSatilanlar1();
    }
}
