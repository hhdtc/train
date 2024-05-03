using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ShipperRegionRepositoryAsync : IShipperRegionRepositoryAsync
    {

        protected readonly EcommerceDbContext _context;
        public ShipperRegionRepositoryAsync(EcommerceDbContext c)
        {
            _context = c;
        }

        public async Task<int> DeleteAsync(ShipperRegion entity)
        {
            _context.Set<ShipperRegion>().Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ShipperRegion>> GetAllAsync()
        {
            return await _context.Set<ShipperRegion>().ToListAsync();

        }


        public async Task<IEnumerable<ShipperRegion>> GetByShipperIdAsync(int id)
        {
            return await _context.Set<ShipperRegion>().Where(x => x.ShipperId == id).ToListAsync();
        }

        public async Task<IEnumerable<ShipperRegion>> GetByRegionIdAsync(int id)
        {
            return await _context.Set<ShipperRegion>().Where(x => x.RegionId == id).ToListAsync();
        }

        public async Task<int> InsertAsync(ShipperRegion entity)
        {
            _context.Set<ShipperRegion>().Add(entity);
            return await (_context.SaveChangesAsync());
        }
    }
}
