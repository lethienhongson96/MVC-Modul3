using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Models.Entities;
using StoreManagement.Services;

namespace StoreManagement.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            this._orderService = orderService;
        }
        public IActionResult Index()
        {
            return View(_orderService.GetOrderList());
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                if (_orderService.CreateOrder(order) > 0)
                    return RedirectToAction("Index", "Order");
                else
                    ModelState.AddModelError("","some thing wrong");
            }
            return View(order);
        }

        [Route("/Order/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _orderService.DeleteOrder(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_orderService.GetOrder(id));
        }

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (_orderService.UpdateOrder(order)>0)
            {
                return RedirectToAction("Index","Order");
            }
            ModelState.AddModelError("","some thing wrong");

            return View(order);
        }
    }
}
