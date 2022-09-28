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
    public class CustomerManager : GenericManager<Customer>, ICustomerService
    {
        public static CustomerManager Instance => new CustomerManager(new EfCustomerDal());
        public CustomerManager(IGenericDal<Customer> genericDal) : base(genericDal)
        {
        }
    }
}
