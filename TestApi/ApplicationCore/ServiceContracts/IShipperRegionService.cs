using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IShipperRegionServiceAsync
    {
        Task<int> InsertAsync(ShipperRegionRequestModel model);
        Task<int> DeleteAsync(ShipperRegionRequestModel model);

        Task<IEnumerable<ShipperRegionResponseModel>> GetByShipperId(int id);

        Task<IEnumerable<ShipperRegionResponseModel>> GetByRegionId(int id);

    }
}
