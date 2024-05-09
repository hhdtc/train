using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shipper.ApplicationCore.Model.RequestModel;
using Shipper.ApplicationCore.ServiceContract;

namespace Shipper.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShipperRegionController : ControllerBase
    {
        private readonly IShipperRegionServiceAsync _service;
        public ShipperRegionController(IShipperRegionServiceAsync service) { _service = service; }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByShipperId(int id)
        {
            return Ok(await _service.GetByShipperId(id));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByRegionId(int id)
        {
            return Ok(await _service.GetByRegionId(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShipperRegionRequestModel model)
        {
            return Ok(await _service.InsertAsync(model));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(ShipperRegionRequestModel model)
        {
            return Ok(await _service.DeleteAsync(model));
        }
    }
}
