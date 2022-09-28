using Data.Services.Abstract;

using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        IGenericDal<T> genericDal;

        public GenericManager(IGenericDal<T> genericDal) //Abstracttı kullanamayız ctor oluşturmazsak
        {
            this.genericDal = genericDal;
        }

        public List<T> CreatedToday1(string tarihStr)
        {
            return genericDal.CreatedToday(tarihStr);
        }

        public T GetById(int id)
        {
            return genericDal.GetByID(id);
        }

        public List<T> GetList()
        {
            return genericDal.GetListAll();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            return genericDal.GetListAll(filter);
        }

        public T GetOne1(Expression<Func<T, bool>> filter)
        {
            return genericDal.GetOne(filter);
        }

        public void TAdd(T t)
        {
            genericDal.Insert(t);
        }

        public void TDelete(T t)
        {
            genericDal.Delete(t);
        }

        public int ToplamSayi1()
        {
            return genericDal.ToplamSayi();
        }

        public void TUpdate(T t)
        {
            genericDal.Update(t);
        }

        

    }
}
