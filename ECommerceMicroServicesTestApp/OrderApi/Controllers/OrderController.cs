using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.ApplicationCore.Entity;
using Order.ApplicationCore.Model.RequestModel;
using Order.ApplicationCore.Model.ResponseModel;
using Order.ApplicationCore.ServiceContract;
using OrderApi.model;
using OrderApi.Util;

namespace OrderApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : BaseController<Orders,OrderRequestModel,OrderResponseModel>
    {
        public OrderController(IService<Orders, OrderRequestModel, OrderResponseModel> service,HttpClient client) : base(service,client)
        {
        }



        [HttpGet]
        public async Task<IActionResult> GetsProducts() { 
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URLConstant.BaseURL);
            HttpResponseMessage message =  await client.GetAsync(URLConstant.PRODUCT_GET_ALL);
            if (message != null) {
                if (message.IsSuccessStatusCode) {
                    var result = await message.Content.ReadFromJsonAsync<List<Product>>();
                    return Ok(result);
                }
            }

            return NoContent();
        }
    }
}
