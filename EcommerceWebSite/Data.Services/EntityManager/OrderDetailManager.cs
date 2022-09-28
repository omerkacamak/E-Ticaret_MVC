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
    public class OrderDetailManager : GenericManager<OrderDetail>, IOrderDetailService
    {
        public static OrderDetailManager Instance => new OrderDetailManager(new EfOrderDetailDal());
        IOrderDetailDal orderDetailDal;

        public OrderDetailManager(IGenericDal<OrderDetail> genericDal) : base(genericDal)
        {
            orderDetailDal = new EfOrderDetailDal();
        }

        public List<OrderDetail> getListWithProducts1(Expression<Func<OrderDetail, bool>> filter)
        {
           return orderDetailDal.getListWithProducts(filter);
        }
    }
}
