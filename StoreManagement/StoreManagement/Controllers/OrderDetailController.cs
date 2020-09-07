using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreManagement.Models.Entities;
using StoreManagement.Services;

namespace StoreManagement.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailService orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            this.orderDetailService = orderDetailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WatchOrderDetail(int id) =>
            View(orderDetailService.GetOrderByid(id));

        [HttpGet]
        public IActionResult Create(int id) =>
            View(orderDetailService.CreateByOrderId(id));

        [HttpPost]
        public IActionResult Create(OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                if (orderDetailService.CreateOrderDetail(orderDetail) > 0 && orderDetail.Quantity>0)
                    return RedirectToAction("Index", "Order");
                else
                    ModelState.AddModelError("", "Quantity not Null");
            }
            else
                ModelState.AddModelError("", "Some thing wrong");

            return View(orderDetail);
        }

        public JsonResult GetProductsByCategoryId(int id) =>
             Json(new SelectList(orderDetailService.GetListProductByCategoryId(id), "Id", "Name"));

        [Route("/OrderDetail/GetPrice/{ProductId}/{Discount}/{Quantity}")]
        public JsonResult GetPrice(int ProductId, int Discount, int Quantity)
        {
            Product product = orderDetailService.GetProductById(ProductId);

            return Json(orderDetailService.CalculateMoney(product.PricePerUnit,Discount,Quantity));
        }

        public JsonResult DefaultByProductId(int id)
        {
            Product product = orderDetailService.GetProductById(id);

            return Json(product.PricePerUnit);
        }
    }
}
