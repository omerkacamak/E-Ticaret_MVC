using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMainCategoryDal : IGenericDal<MainCategory>
    {
        List<MainCategory> getAllwithCategory();
        MainCategory getAllwithProduct(Expression<Func<MainCategory, bool>> filter);
    }
}
