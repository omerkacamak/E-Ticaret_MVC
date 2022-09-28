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
    public class PaymentManager : GenericManager<Payment>, IPaymentService
    {
        public static PaymentManager Instance => new PaymentManager(new EfPaymentDal());
        IPaymentDal paymentDal;
        public PaymentManager(IGenericDal<Payment> genericDal) : base(genericDal)
        {
            paymentDal = new EfPaymentDal();
        }
    }
}
