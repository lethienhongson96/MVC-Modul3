using StoreManagement.Models;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly StoreDbContext _context;

        public OrderDetailService(StoreDbContext context)
        {
            _context = context;
        }

        public double CalculateMoney(double PriceProduct, double Percent, int Quantity) =>
            PriceProduct * Quantity * ((100 - Percent) / 100);

        public OrderDetail CreateByOrderId(int id)
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                OrderId = id
            };

            return orderDetail;
        }

        public int CreateOrderDetail(OrderDetail orderDetail)
        {
            List<OrderDetail> orderDetails = _context.OrderDetails.ToList();

            OrderDetail FindOrderDetail = orderDetails.Find(el =>
                                        el.OrderId == orderDetail.OrderId &&
                                        el.ProductId == orderDetail.ProductId);
            Product product = _context.Products.FirstOrDefault(el => el.Id == orderDetail.ProductId);

            if (orderDetails.Contains(FindOrderDetail))
            {
                FindOrderDetail.Quantity += orderDetail.Quantity;
                FindOrderDetail.UnitPrice += CalculateMoney(product.PricePerUnit, orderDetail.Discount, orderDetail.Quantity);

                _context.Update(FindOrderDetail);
            }
            else
            {
                orderDetail.UnitPrice = CalculateMoney(product.PricePerUnit, orderDetail.Discount, orderDetail.Quantity);

                _context.Add(orderDetail);
            }

            return _context.SaveChanges();
        }

        public int DeleteOrderDetail(int OrderId, int ProductId)
        {
            var OrderDetail = _context.OrderDetails.FirstOrDefault(el =>
                                el.OrderId == OrderId &&
                                el.ProductId == ProductId);
            _context.Remove(OrderDetail);
            return _context.SaveChanges();
        }

        public List<Product> GetListProductByCategoryId(int id) =>
             _context.Products.ToList().FindAll(el => el.CategoryId == id);

        public Order GetOrderByid(int id) =>
            _context.Orders.FirstOrDefault(el => el.Id == id);

        public OrderDetail GetOrderDetailByIds(int ProductId, int OrderId)
        {
            var orderdetail = _context.OrderDetails.FirstOrDefault(el =>
                                el.ProductId == ProductId &&
                                el.OrderId == OrderId);
            return (orderdetail);
        }

        public Product GetProductById(int id) =>
            _context.Products.FirstOrDefault(el => el.Id == id);

        public int UpdateOrderDetail(OrderDetail orderDetail)
        {
            _context.Update(orderDetail);
            return _context.SaveChanges();
        }
    }
}
