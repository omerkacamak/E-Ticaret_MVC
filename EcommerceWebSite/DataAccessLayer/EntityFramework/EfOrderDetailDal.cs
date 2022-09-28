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
    public class EfOrderDetailDal : GenericRepository<OrderDetail>, IOrderDetailDal
    {
        public List<OrderDetail> getListWithProducts(Expression<Func<OrderDetail, bool>> filter)
        {
            using var c = new Context();
            return c.OrderDetails.Where(filter).Include(i => i.ProductItem).ThenInclude(x => x.Product).ToList();
        }
    }
}
