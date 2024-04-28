using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Training.Ecommerce.MvcApp.Controllers
{
    public class ShipperController : Controller
    {
        private readonly IShipperService _shipperService;
        public ShipperController(IShipperService _shipperService)
        {
            this._shipperService = _shipperService;
        }


        public IActionResult Index()
        {
            var collection = _shipperService.GetAllShipper();
            return View(collection);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(ShipperRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _shipperService.InsertShipper(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            var item = _shipperService.GetShipperbyId(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(ShipperResponseModel model)
        {
            _shipperService.DeleteShipper(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _shipperService.GetShipperbyId(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ShipperResponseModel model)
        {
            if (ModelState.IsValid)
            {
                ShipperRequestModel c = new ShipperRequestModel();
                c.Id = model.Id;
                c.Name = model.Name;
                _shipperService.UpdateShipper(c);
                return RedirectToAction("Index");
            }
            return View(model);

        }
    }
}
