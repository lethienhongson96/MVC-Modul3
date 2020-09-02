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

        [HttpGet]
        public IActionResult Edit(int id) => View(categoryService.GetCategoryById(id));

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                var FindCategory = categoryService.GetCategoryById(category.Id);

                FindCategory.Name = category.Name;
                FindCategory.Status = category.Status;
                FindCategory.Products = category.Products;
            }

            return View();
        }

        [HttpGet]
        public IActionResult WatchProducts(int id)
        {
            return View(categoryService.GetCategoryById(id));
        }
    }
}
