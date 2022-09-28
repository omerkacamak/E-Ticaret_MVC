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
    public class OrderManager : GenericManager<Order>, IOrderService
    {
        public static OrderManager Instance => new OrderManager(new EfOrderDal());

        

        IOrderDal orderDal;
        public OrderManager(IGenericDal<Order> genericDal) : base(genericDal)
        {
            orderDal = new EfOrderDal();
        }

        
        
    }
}
