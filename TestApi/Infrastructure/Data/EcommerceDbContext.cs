using ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    public class EcommerceDbContext:IdentityDbContext<ApplicationUser>
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
        public DbSet<Review> Reviews { get; set; }

        public DbSet<PromotionDetail> PromotionDetails { get; set; }

        public DbSet<CategoryVariation> CategoryVariations { get; set; }

        public DbSet<VariationValue> VariationValues { get; set; }

        public DbSet<ProductVariationValues> ProductVariationValues { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<ShipperRegion> ShipperRegions { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<UserAddress> userAddresses { get; set; }

        public DbSet<ShoppingCartItem> shoppingCartItems { get; set; }

        public DbSet<PaymentType> paymentTypes { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
