using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shipper.ApplicationCore.ServiceContract;
using Shipper.Util;

namespace Shipper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Model, Request, Response> : ControllerBase
    {
        protected IService<Model, Request, Response> _service;

        protected HttpClient _client;
        public BaseController(IService<Model, Request, Response> service, HttpClient client)
        {
            _service = service;
            _client = client;
            _client.BaseAddress = new Uri(URLConstant.BaseURL);
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{Id:int}")]
        public virtual async Task<IActionResult> GetAsync(int Id)
        {
            return Ok(await _service.GetByIdAsync(Id));
        }

        [HttpPost]
        public virtual async Task<IActionResult> InsertAsync(Request model)
        {
            return Ok(await _service.InsertAsync(model));

        }

        [HttpPut("{Id:int}")]
        //[HttpPut]
        public virtual async Task<IActionResult> UpdateAsync(Request model, int Id)
        {
            return Ok(await _service.UpdateAsync(model, Id));

        }

        [HttpDelete("{id:int}")]
        //[HttpDelete]
        public virtual async Task<IActionResult> DeleteAsync(int id)
        {
            //Console.Write("id is " + id);
            return Ok(await _service.DeleteAsync(id));
        }

        protected async Task<Y> CallApi<Y>(string url) where Y : class
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage message = await _client.GetAsync(url);
            if (message != null)
            {
                if (message.IsSuccessStatusCode)
                {
                    return await message.Content.ReadFromJsonAsync<Y>();

                }
            }
            return null;
        }
    }
}
