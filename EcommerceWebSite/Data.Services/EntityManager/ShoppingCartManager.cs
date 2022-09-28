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
    public class ShoppingCartManager : GenericManager<ShoppingCart>,IShoppingCartService
    {
        public static ShoppingCartManager Instance => new ShoppingCartManager(new EfShoppingCartDal());
        IShoppingCartDal shoppingCartDal;
        public ShoppingCartManager(IGenericDal<ShoppingCart> genericDal) : base(genericDal)
        {
            shoppingCartDal = new EfShoppingCartDal();
        }

        public ShoppingCart getOneWithItems1(Expression<Func<ShoppingCart, bool>> filter)
        {
            return shoppingCartDal.getOneWithItems(filter);
        }

        public ShoppingCart getOneOnlyItems1(Expression<Func<ShoppingCart, bool>> filter)
        {
            return shoppingCartDal.getOneOnlyItems(filter);
        }
    }
}
