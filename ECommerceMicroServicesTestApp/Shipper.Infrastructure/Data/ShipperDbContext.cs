using Microsoft.EntityFrameworkCore;
using Shipper.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.Infrastructure.Data
{
    public class ShipperDbContext : DbContext
    {
        public ShipperDbContext(DbContextOptions<ShipperDbContext> options) : base(options){}


        public DbSet<Region> Regions { get; set; }
        public DbSet<Shippers> Shippers { get; set; }

        public DbSet<ShipperRegion> ShipperRegions { get; set; }

    }
}
