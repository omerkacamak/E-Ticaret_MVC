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
    public class MainCategoryManager : GenericManager<MainCategory>, IMainCategoryService
    {
        public static MainCategoryManager Instance => new MainCategoryManager(new EfMainCategoryDal());
        IMainCategoryDal mainCategoryDal;
        public MainCategoryManager(IGenericDal<MainCategory> genericDal) : base(genericDal)
        {
            mainCategoryDal = new EfMainCategoryDal();
        }

        public List<MainCategory> getAllwithCategory1()
        {
           return mainCategoryDal.getAllwithCategory();
        }

        public MainCategory getAllwithProduct1(Expression<Func<MainCategory, bool>> filter)
        {
            return mainCategoryDal.getAllwithProduct(filter);
        }
    }
}
