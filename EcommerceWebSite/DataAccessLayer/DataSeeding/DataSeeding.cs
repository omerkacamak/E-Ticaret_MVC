using Data.Models;
using DataAccessLayer.Connection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataSeeding
{
    public class DataSeeding
    {
        public static void Seed(DbContext context)
        {
            if(context.Database.GetPendingMigrations().Count()==0)
            {
                if(context is Context)
                {
                    Context _context = context as  Context;
                    if(_context.MainCategories.Count()==0)
                    {
                        _context.MainCategories.AddRange(MainCategoryList);
                    }
                    if (_context.Categories.Count() == 0)
                    {
                        _context.Categories.AddRange(CategoryList);
                    }
                    
                }
                context.SaveChanges();
            }
        }
        private static List<MainCategory> MainCategoryList = new List<MainCategory>()
        {
            new MainCategory(){Name="Giyim"},
            new MainCategory(){Name="Elektronik"},
            new MainCategory(){Name="Ev Yaşam"},
            new MainCategory(){Name="Kozmetik"},

        };
        private static List<Category> CategoryList = new List<Category>()
        {
            new Category(){CategoryName="Ayakkabı",MainCategoryID=1,CategoryStatus=true,CategoryDescription="hakkında"},
            new Category(){CategoryName="Çanta",MainCategoryID=1,CategoryStatus=true,CategoryDescription="hakkında"},
            new Category(){CategoryName="Bilgisayar",MainCategoryID=2,CategoryStatus=true,CategoryDescription="hakkında"},
            new Category(){CategoryName="Mobilya",MainCategoryID=3,CategoryStatus=true,CategoryDescription="hakkında"},
            new Category(){CategoryName="Parfüm",MainCategoryID=4,CategoryStatus=true,CategoryDescription="hakkında"},
        };
    }

    
}
