using ApplicationCore.Model.Request;
using ApplicationCore.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServiceAsync _productServiceAsync;
        public ProductController(IProductServiceAsync _service)
        {
            _productServiceAsync = _service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _productServiceAsync.GetAllProductsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync(ProductRequestModel model)
        {
            return Ok(await _productServiceAsync.InsertProductAsync(model));

        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateAsync(ProductRequestModel model, int Id)
        {
            return Ok(await _productServiceAsync.UpdateProductAsync(model, Id));

        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _productServiceAsync.DeleteProductAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWithPage(int categoryId, int pageNum, int pageSize = 5)
        {
            return Ok(await _productServiceAsync.GetProductPageAsync(categoryId,pageNum,pageSize));
        }
    }
}
