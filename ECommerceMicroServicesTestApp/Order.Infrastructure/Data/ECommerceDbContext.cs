
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
using Order.ApplicationCore.Entity;

namespace Order.Infrastructure.Data
{
    public class EcommerceDbContext : IdentityDbContext<ApplicationUser>
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) :
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

        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
