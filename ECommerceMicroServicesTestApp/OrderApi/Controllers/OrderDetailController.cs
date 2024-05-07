using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.ApplicationCore.Entity;
using Order.ApplicationCore.Model.RequestModel;
using Order.ApplicationCore.Model.ResponseModel;
using Order.ApplicationCore.ServiceContract;
using OrderApi.Util;

namespace OrderApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderDetailController : BaseController<OrderDetail, OrderDetailRequestModel, OrderDetailResponseModel>
    {
        public OrderDetailController(IService<OrderDetail, OrderDetailRequestModel, OrderDetailResponseModel> service, HttpClient client) : base(service,client)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAllByOrderid(int id) {
            var result =await _service.GetAllByFilterAsync((x) => { return x.Id == id; });
            if (result != null)
            {
                foreach (var i in result) {
                    i.Product = await CallApi<ProductResponseModel>(URLConstant.PRODUCT_GET_BY_ID+id.ToString());
                    i.ProductName = i.Product.Name;
             
                }
                return Ok(result);
            }
            else {
                return NoContent();
            }
        }
    }
}
