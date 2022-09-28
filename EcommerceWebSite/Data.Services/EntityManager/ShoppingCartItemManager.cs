using Data.Models;
using Data.Services.Abstract;
using Data.Services.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.EntityManager
{
    public class ShoppingCartItemManager : GenericManager<ShoppingCartItems>, IShoppingCartItemService
    {
        public static ShoppingCartItemManager Instance => new ShoppingCartItemManager(new EfShoppingCartItemDal());
        IShoppingCartItemDal ShoppingCartItemDal;
        public ShoppingCartItemManager(IGenericDal<ShoppingCartItems> genericDal) : base(genericDal)
        {
            ShoppingCartItemDal = new EfShoppingCartItemDal();
        }
    }
}
