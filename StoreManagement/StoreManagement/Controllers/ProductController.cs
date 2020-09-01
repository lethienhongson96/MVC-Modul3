using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Models.Entities;
using StoreManagement.Services;

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
            return View();
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var productid = _productService.CreateProduct(product);
                if (productid > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }
    }
}
