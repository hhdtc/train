using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IShipperService
    {

        IEnumerable<ShipperResponseModel> GetAllShipper();
        int InsertShipper(ShipperRequestModel category);
        int UpdateShipper(ShipperRequestModel category);
        int DeleteShipper(int id);
        ShipperResponseModel GetShipperbyId(int id);
    }
}
