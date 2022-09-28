using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductItemDal: IGenericDal<ProductItem>
    {
        List<ProductItem> haftaninUrunleri();
        ProductItem getOneWithProduct(Expression<Func<ProductItem, bool>> filter);
        List<ProductItem> yeniGelenler(); 
        List<ProductItem> cokSatanlar(); 
        List<ProductItem> anlikSatilanlar(); 
      
        
        
    }
}
