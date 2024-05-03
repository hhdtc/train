using ApplicationCore.Model.Request;
using ApplicationCore.ServiceContracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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

        [HttpGet("{Id:int}")]
        public async Task<IActionResult> GetAllAsync(int Id)
        {
            return Ok(await _categoryServiceAsync.GetCategoryByIdAsync(Id));
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync(CategoryRequestModel model) {
            return Ok(await _categoryServiceAsync.InsertCategoryAsync(model));

        }

        [HttpPut("{Id:int}")]
        //[HttpPut]
        public async Task<IActionResult> UpdateAsync(CategoryRequestModel model, int Id)
        {
            return Ok(await _categoryServiceAsync.UpdateCategoryAsync(model,Id));

        }

        [HttpDelete("{id:int}")]
        //[HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id) {
            Console.Write("id is " + id);
            return Ok(await _categoryServiceAsync.DeleteCategoryAsync(id));
        }
    }
}
