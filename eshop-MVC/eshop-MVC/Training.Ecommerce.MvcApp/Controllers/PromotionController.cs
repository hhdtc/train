using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Training.Ecommerce.MvcApp.Controllers
{
    public class PromotionController : Controller
    {
        private readonly IPromotionService _promotionService;
        public PromotionController(IPromotionService _promotionService)
        {
            this._promotionService = _promotionService;
        }


        public IActionResult Index()
        {
            var collection = _promotionService.GetAllPromotion();
            return View(collection);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(PromotionRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _promotionService.InsertPromotion(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            var item = _promotionService.GetPromotionById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(PromotionResponseModel model)
        {
            _promotionService.DeletePromotion(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _promotionService.GetPromotionById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(PromotionResponseModel model)
        {
            if (ModelState.IsValid)
            {
                PromotionRequestModel c = new PromotionRequestModel();
                c.Id = model.Id;
                c.Name = model.Name;
                _promotionService.UpdatePromotion(c);
                return RedirectToAction("Index");
            }
            return View(model);

        }
    }
}
