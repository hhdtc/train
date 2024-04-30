using ApplicationCore.Model.Request;
using ApplicationCore.ServiceContracts;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Training.Ecommerce.MvcApp.Controllers
{
    public class ReviewController : Controller
    {
        IReviewService _reviewService;
        IProductService _productService;

        public ReviewController(IReviewService reviewService, IProductService productService)
        {
            _reviewService = reviewService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_reviewService.GetAllReview());
        }

        public IActionResult Customer(int id) {
            return View(_reviewService.GetReviewByCustomerId(id));
        }

        public IActionResult Product(int id) {
            return View(_reviewService.GetReviewByProductId(id));
        }


        public IActionResult Add() {
            ViewBag.ProductId = _productService.GetSelectItem();
            return View();
        }

        [HttpPost]
        public IActionResult Add(ReviewRequestModel review)
        {
            _reviewService.InsertReview(review);
            return View();
        }
    }
}
