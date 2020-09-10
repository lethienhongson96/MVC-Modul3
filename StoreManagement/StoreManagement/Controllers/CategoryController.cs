using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using StoreManagement.Models.Entities;
using StoreManagement.Models.ViewModels;
using StoreManagement.Services;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) =>
            this._categoryService = categoryService;

        public IActionResult Index() =>
            View(_categoryService.GetCategories());

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                if (_categoryService.CreateCategory(category) > 0)
                    return RedirectToAction("Index", "Category");
                else
                    ModelState.AddModelError("", "some thing wrong");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int id) => View(_categoryService.GetCategoryById(id));

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                if (_categoryService.UpdateCategory(category) > 0)
                    return RedirectToAction("Index", "Category");
                else
                    ModelState.AddModelError("", "some thing wrong");
            }

            return View();
        }

        [HttpGet]
        public IActionResult WatchProducts(int id) =>
             View(_categoryService.GetCategoryById(id));

        [Route("/Category/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _categoryService.DeleteCategory(id);
            return Json(new { result });
        }

        [Route("/Category/RemoveProductFromCategory/{id}")]
        public IActionResult RemoveProductFromCategory(int id)
        {
            var result = _categoryService.MoveCategoryForProduct(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult MoveDefaultToAnother(int id)
        {
            return View(_categoryService.GetListProductByCategoryId(id));
        }

        public ActionResult MoveDefaultToAnother([FromBody] List<ViewUpdate> ViewUpdates)
        {
            /*if (_categoryService.MoveRangeCategoryForProduct(products) > 0)
                return RedirectToAction("Category","Index");*/
            return Ok(ViewUpdates);
        }
    }
}
