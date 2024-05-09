using Shipper.ApplicationCore.Model.RequestModel;
using Shipper.ApplicationCore.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.ApplicationCore.ServiceContract
{
    public interface IShipperRegionServiceAsync
    {
        Task<int> InsertAsync(ShipperRegionRequestModel model);
        Task<int> DeleteAsync(ShipperRegionRequestModel model);

        Task<IEnumerable<ShipperRegionResponseModel>> GetByShipperId(int id);

        Task<IEnumerable<ShipperRegionResponseModel>> GetByRegionId(int id);

    }
}
