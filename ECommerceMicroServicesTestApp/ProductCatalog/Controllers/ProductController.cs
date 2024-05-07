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
    public class ProductController : BaseController<Product, ProductRequestModel, ProductResponseModel>
    {
        public ProductController(IService<Product, ProductRequestModel, ProductResponseModel> service) : base(service)
        {
        }
    }
}
