using Data.Models;
using Data.Models.WriteSql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Connection
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0STP5KA;database=EcommerceDatabase1;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
           

        

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItems> ShoppingCartItems { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<SliderBars> SliderBars { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
       
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<Talep> Taleps { get; set; }
        public DbSet<GirisZamani> GirisZamani { get; set; }
       // public DbSet<ProductItemSql> ProductItemSql { get; set; }
    }
}
