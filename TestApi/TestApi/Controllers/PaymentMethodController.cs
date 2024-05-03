using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using Infrastructure.Repository;
using Infrastructure.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentMethodController : BaseController<PaymentMethod, PaymentMethodRequestModel, PaymentMethodResponseModel>
    {
        public PaymentMethodController(IService<PaymentMethod, PaymentMethodRequestModel, PaymentMethodResponseModel> service) : base(service)
        {
        }
    }
}