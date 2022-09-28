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
    public class TalepManager : GenericManager<Talep>, ITalepService
    {
        public static TalepManager Instance => new TalepManager(new EfTalepDal());
        ITalepDal talepDal;
        public TalepManager(IGenericDal<Talep> genericDal) : base(genericDal)
        {
            talepDal = new EfTalepDal();
        }
    }
}
