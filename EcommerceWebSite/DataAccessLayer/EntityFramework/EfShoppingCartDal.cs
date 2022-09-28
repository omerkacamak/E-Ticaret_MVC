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
    public class EfShoppingCartDal : GenericRepository<ShoppingCart>, IShoppingCartDal
    {
        public ShoppingCart getOneOnlyItems(Expression<Func<ShoppingCart, bool>> filter)
        {
            using var c = new Context();
            return c.ShoppingCarts.Where(filter).Include(i => i.ShoppingCartItems).FirstOrDefault();
        }

        public ShoppingCart getOneWithItems(Expression<Func<ShoppingCart, bool>> filter)
        {
            using var c = new Context();
            return c.ShoppingCarts.Where(filter).Include(i=>i.ShoppingCartItems).ThenInclude(x=>x.ProductItem).ThenInclude(c=>c.Product).FirstOrDefault();
        }
    }
}
