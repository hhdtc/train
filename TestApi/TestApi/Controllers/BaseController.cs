using ApplicationCore.Model.Request;
using ApplicationCore.ServiceContracts;
using Infrastructure.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    public class BaseController<  Model, Request, Response> : ControllerBase
    {
        private IService< Model, Request, Response> _service;
        public BaseController(IService< Model, Request, Response> service) { _service = service; }

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
    }
}
