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
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        public static CategoryManager Instance => new CategoryManager(new EfCategoryDal());
        ICategoryDal categoryDal;

        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
            categoryDal = new EfCategoryDal();
        }

        public void deneme1()
        {
            categoryDal.Deneme();
        }
    }
}
