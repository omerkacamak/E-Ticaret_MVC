using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList();
        List<T> GetListAll(Expression<Func<T, bool>> filter);
        T GetById(int id);
        T GetOne1(Expression<Func<T, bool>> filter);
        int ToplamSayi1();
        List<T> CreatedToday1(string tarihStr);
    }
}
