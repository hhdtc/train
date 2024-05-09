using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shipper.ApplicationCore.Entity;
using Shipper.ApplicationCore.Model.RequestModel;
using Shipper.ApplicationCore.Model.ResponseModel;
using Shipper.ApplicationCore.ServiceContract;

namespace Shipper.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegionController : BaseController<Region, RegionRequestModel, RegionResponseModel>
    {
        public RegionController(IService<Region, RegionRequestModel, RegionResponseModel> service, HttpClient client) : base(service, client)
        {
            
        }
    }
}
