using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shipper.ApplicationCore.Entity;
using Shipper.ApplicationCore.Model.RequestModel;
using Shipper.ApplicationCore.Model.ResponseModel;
using Shipper.ApplicationCore.ServiceContract;

namespace Shipper.Controllers
{
    [Route("api/[controller]/[action]/[action]")]
    [ApiController]
    public class ShipperController : BaseController<Shippers, ShipperRequestModel, ShipperResponseModel>
    {
        public ShipperController(IService<Shippers, ShipperRequestModel, ShipperResponseModel> service, HttpClient client) : base(service, client)
        {
        }
    }
}
