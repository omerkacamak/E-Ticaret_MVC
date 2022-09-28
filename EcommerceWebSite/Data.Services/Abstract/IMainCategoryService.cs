using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Abstract
{
    public interface IMainCategoryService : IGenericService<MainCategory>
    {
        List<MainCategory> getAllwithCategory1();
        MainCategory getAllwithProduct1(Expression<Func<MainCategory, bool>> filter);
    }
}
