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
    public class GirisZamaniManager : GenericManager<GirisZamani>, IGirisZamaniService
    {
        public static GirisZamaniManager Instance => new GirisZamaniManager(new EfGirisZamaniDal());
        IGirisZamaniDal girisZamaniDal;
        public GirisZamaniManager(IGenericDal<GirisZamani> genericDal) : base(genericDal)
        {
            girisZamaniDal = new EfGirisZamaniDal();
        }

    }
}
