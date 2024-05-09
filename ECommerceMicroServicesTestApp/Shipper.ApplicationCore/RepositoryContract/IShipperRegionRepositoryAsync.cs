using Shipper.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.ApplicationCore.RepositoryContract
{
    public interface IShipperRegionRepositoryAsync
    {
        Task<int> InsertAsync(ShipperRegion entity);
        Task<IEnumerable<ShipperRegion>> GetByRegionIdAsync(int id);
        Task<IEnumerable<ShipperRegion>> GetByShipperIdAsync(int id);
        Task<int> DeleteAsync(ShipperRegion entity);
        Task<IEnumerable<ShipperRegion>> GetAllAsync();
        // IEnumerable<T> Filter(Func<T, bool> predicate);
    }
}
