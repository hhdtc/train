using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Data;
using ApplicationCore.ServiceContracts;
using ApplicationCore.Model.Request;
using Infrastructure.Service;

namespace Training.Ecommerce.MvcApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductsController(IProductService _productService, ICategoryService categoryService)
        {
            this._productService = _productService;
            this._categoryService = categoryService;
        }
        // GET: Products
        public async Task<IActionResult> Index()
        {
            var ecommerceDbContext = _productService.GetAllProducts();
            return View(ecommerceDbContext);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewBag.CategoryId = GetCategorySelection();
            return View();
        }

        private List<SelectListItem> GetCategorySelection() {
            var cats = _categoryService.GetAllCategories();
            var selects = new List<SelectListItem> { };
            foreach (var c in cats)
            {
                selects.Add(new SelectListItem { Text = c.CategoryName, Value = c.Id.ToString() });
            }
            return selects;
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductRequestModel product)
        {
            if (ModelState.IsValid)
            {

                Console.Write(product.CategoryId);
                _productService.InsertProduct(product);
                
                
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var item = _productService.GetProductById(id);
            ViewBag.CategoryId = GetCategorySelection();
            return View(item);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductRequestModel product)
        {
            if (ModelState.IsValid)
            {
                _productService.InsertProduct(product);
            }
            return View("index");
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var item = _productService.GetProductById(id);
            return View(item);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
