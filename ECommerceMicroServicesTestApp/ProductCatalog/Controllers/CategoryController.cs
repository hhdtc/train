using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.ApplicationCore.Entity;
using ProductCatalog.ApplicationCore.Model.RequestModel;
using ProductCatalog.ApplicationCore.Model.ResponseModel;
using ProductCatalog.ApplicationCore.ServiceContract;

namespace ProductCatalog.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : BaseController<Category, CategoryRequestModel, CategoryResponseModel>
    {
        public CategoryController(IService<Category, CategoryRequestModel, CategoryResponseModel> service) : base(service)
        {
        }
    }
}
