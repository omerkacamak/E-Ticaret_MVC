using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IShoppingCartDal: IGenericDal<ShoppingCart>
    {
        ShoppingCart getOneWithItems(Expression<Func<ShoppingCart, bool>> filter);
        ShoppingCart getOneOnlyItems(Expression<Func<ShoppingCart, bool>> filter);
    }
}
