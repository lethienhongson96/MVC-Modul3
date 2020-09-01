using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Models.Entities;
using StoreManagement.Services;

namespace StoreManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(categoryService.GetCategories());
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                if (categoryService.CreateCategory(category) > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(category);
        }
    }
}
