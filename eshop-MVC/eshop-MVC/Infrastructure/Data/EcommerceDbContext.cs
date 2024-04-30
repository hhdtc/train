using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EcommerceDbContext:DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options):
            base(options)
        {
                
        }

        //public EcommerceDbContext() { }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Your Connection String");
        }
        */

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<Shipper> Shippers { get; set; }
        //public DbSet<Review> Reviews { get; set; }



    }
}
