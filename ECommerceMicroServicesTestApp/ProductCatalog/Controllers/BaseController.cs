using Microsoft.AspNetCore.Mvc;
using ProductCatalog.ApplicationCore.ServiceContract;

namespace ProductCatalog.Controllers
{
    public class BaseController<Model, Request, Response> : ControllerBase
    {
        private IService<Model, Request, Response> _service;
        public BaseController(IService<Model, Request, Response> service) { _service = service; }

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

        [HttpDelete("{Id:int}")]
        //[HttpDelete]
        public virtual async Task<IActionResult> DeleteAsync(int Id)
        {
            //Console.Write("id is " + id);
            return Ok(await _service.DeleteAsync(Id));
        }
    }
}
