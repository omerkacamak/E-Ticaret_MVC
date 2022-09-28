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
    public class EfMainCategoryDal : GenericRepository<MainCategory>, IMainCategoryDal
    {
        public List<MainCategory> getAllwithCategory()
        {
            using var c = new Context();
            return c.MainCategories.Include(i=>i.AltKategoriler).ToList();
        }

        public MainCategory getAllwithProduct(Expression<Func<MainCategory, bool>> filter)
        {
            using var c = new Context();
            return c.MainCategories.Include(i=>i.AltKategoriler).ThenInclude(c=>c.Products).FirstOrDefault(filter);
        }
    }
}
