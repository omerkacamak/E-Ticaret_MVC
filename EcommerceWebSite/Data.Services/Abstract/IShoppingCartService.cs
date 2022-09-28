using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Abstract
{
    public interface IShoppingCartService : IGenericService<ShoppingCart>
    {
        ShoppingCart getOneWithItems1(Expression<Func<ShoppingCart, bool>> filter);
        ShoppingCart getOneOnlyItems1(Expression<Func<ShoppingCart, bool>> filter);
    }
}
