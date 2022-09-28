using Data.Models;
using DataAccessLayer.Abstract;
using DataAccessLayer.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public List<T> CreatedToday(string tarihStr)
        {
          
            using var c = new Context();
            var model = c.Model;
            var entityTypes = model.GetEntityTypes();
            var entityTypeOfFooBar = entityTypes.First(t => t.ClrType == typeof(T));
            var tableNameAnnotation = entityTypeOfFooBar.GetAnnotation("Relational:TableName");
            var tableName = tableNameAnnotation.Value.ToString();
              
            
            return c.Set<T>().FromSqlRaw($"Select * from {tableName} where convert(date,{tarihStr}) = convert(date, getdate())").ToList();
            
        }
        
        

        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public T GetOne(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).FirstOrDefault();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public int ToplamSayi()
        {
            using var c = new Context();
            return c.Set<T>().Count();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
