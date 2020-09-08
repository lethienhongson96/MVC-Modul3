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
                if (orderDetailService.CreateOrderDetail(orderDetail) > 0 && orderDetail.Quantity > 0)
                    return RedirectToAction("WatchOrderDetail", "OrderDetail", orderDetailService.GetOrderByid(orderDetail.OrderId));
                else
                    ModelState.AddModelError("", "Quantity is not Null");
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

            return Json(orderDetailService.CalculateMoney(product.PricePerUnit, Discount, Quantity));
        }

        public JsonResult DefaultByProductId(int id)
        {
            Product product = orderDetailService.GetProductById(id);

            return Json(product.PricePerUnit);
        }

        [HttpGet]
        public IActionResult Edit(int ProductId, int OrderId)
        {
            return View(orderDetailService.GetOrderDetailByIds(ProductId, OrderId));
        }

        [HttpPost]
        public IActionResult Edit(OrderDetail orderDetail)
        {
            if (orderDetailService.UpdateOrderDetail(orderDetail) > 0)
            {
                return RedirectToAction("WatchOrderDetail", "OrderDetail", orderDetailService.GetOrderByid(orderDetail.OrderId));
            }

            return View(orderDetail);
        }

        [Route("/OrderDetail/Delete/{OrderId}/{ProductId}")]
        public IActionResult Delete(int OrderId,int  ProductId)
        {
            var result = orderDetailService.DeleteOrderDetail(OrderId, ProductId);
            return Json(new { result });
        }
    }
}
