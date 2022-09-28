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
    public class AboutManager : GenericManager<About>, IAboutService
    {
        public static AboutManager Instance => new AboutManager(new EfAboutDal());
        IAboutDal aboutDal;
        public AboutManager(IGenericDal<About> genericDal) : base(genericDal)
        {
            aboutDal = new EfAboutDal();
        }
    }
}
