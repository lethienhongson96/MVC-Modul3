using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Models.Entities;
using StoreManagement.Models.ViewModels;
using StoreManagement.Services;
using System;
using System.IO;

namespace StoreManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetProductList());
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreateProductView productView)
        {
            if (ModelState.IsValid)
            {
                if (_productService.CreateProduct(productView) > 0)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("","something wrong");
                }
            }
            return View();
        }

        [Route("/Product/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _productService.DeleteProduct(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_productService.FindProductToView(id));
        }

        [HttpPost]
        public IActionResult Edit(EditProductView productView)
        {
            if (ModelState.IsValid)
            {
                if (_productService.UpdateProduct(productView) > 0)
                {
                    return RedirectToAction("Index","Product");
                }
            }
            return View(productView);
        }
    }
}
