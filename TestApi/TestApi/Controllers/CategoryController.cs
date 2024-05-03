using ApplicationCore.Model.Request;
using ApplicationCore.ServiceContracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryServiceAsync _categoryServiceAsync;
        public CategoryController(ICategoryServiceAsync _service) {
            _categoryServiceAsync = _service;
        }
        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllAsync() {
            return Ok(await _categoryServiceAsync.GetAllCategoriesAsync());
        }
        [HttpPost]
        public async Task<IActionResult> InsertAsync(CategoryRequestModel model) {
            return Ok(await _categoryServiceAsync.InsertCategoryAsync(model));

        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateAsync(CategoryRequestModel model, int Id)
        {
            return Ok(await _categoryServiceAsync.UpdateCategoryAsync(model,Id));

        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAsync(int id) {
            return Ok(await _categoryServiceAsync.DeleteCategoryAsync(id));
        }
    }
}
