using ApplicationCore.Model.Request;
using ApplicationCore.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountServiceAsync _service;
        public AccountController(IAccountServiceAsync service) { _service = service; }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpRequestModel model) {
            var result = await _service.SignUpAsync(model);
            if (result.Succeeded) {
                return Ok("success");
            }
            else {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestModel model) {
            return Ok(await _service.LoginAsync(model));
        }
    }
}
