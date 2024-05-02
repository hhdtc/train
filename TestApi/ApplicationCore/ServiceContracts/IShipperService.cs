using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IShipperServiceAsync
    {

        Task<IEnumerable<ShipperResponseModel>> GetAllShipperAsync();
        Task<int> InsertShipperAsync(ShipperRequestModel category);
        Task<int> UpdateShipperAsync(ShipperRequestModel category, int id);
        Task<int> DeleteShipperAsync(int id);
        Task<ShipperResponseModel> GetShipperbyIdAsync(int id);
    }
}
