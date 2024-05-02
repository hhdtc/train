using ApplicationCore.Model.Request;
using ApplicationCore.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryServiceAsync _categoryServiceAsync;
        public CategoryController(ICategoryServiceAsync _service) {
            _categoryServiceAsync = _service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            return Ok(await _categoryServiceAsync.GetAllCategoriesAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CategoryRequestModel model) {
            return Ok(await _categoryServiceAsync.InsertCategoryAsync(model));

        }

        [HttpPost("{Id}")]
        public async Task<IActionResult> Update(CategoryRequestModel model, int Id)
        {
            return Ok(await _categoryServiceAsync.UpdateCategoryAsync(model,Id));

        }
    }
}
