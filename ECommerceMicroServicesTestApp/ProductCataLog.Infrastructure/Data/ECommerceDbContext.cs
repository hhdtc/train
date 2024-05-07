using ProductCatalog.ApplicationCore.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;

//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProductCataLog.Infrastructure.Data
{
    //public class EcommerceDbContext : IdentityDbContext<ApplicationUser>
    public class EcommerceDbContext : DbContext
    {
        
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) :
            base(options)
        {

        }
        


        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Your Connection String");
        }
        */

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<CategoryVariation> CategoryVariations { get; set; }

        public DbSet<VariationValue> VariationValues { get; set; }

        public DbSet<ProductVariationValues> ProductVariationValues { get; set; }

    }
}
