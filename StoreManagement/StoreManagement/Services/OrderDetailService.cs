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
        private readonly StoreDbContext context;

        public OrderDetailService(StoreDbContext context)
        {
            this.context = context;
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
            List<OrderDetail> orderDetails = context.OrderDetails.ToList();

            OrderDetail FindOrderDetail = orderDetails.Find(el =>
                                        el.OrderId == orderDetail.OrderId &&
                                        el.ProductId == orderDetail.ProductId);
            Product product = context.Products.FirstOrDefault(el => el.Id == orderDetail.ProductId);

            if (orderDetails.Contains(FindOrderDetail))
            {
                FindOrderDetail.Quantity += orderDetail.Quantity;
                FindOrderDetail.UnitPrice += CalculateMoney(product.PricePerUnit, orderDetail.Discount, orderDetail.Quantity);

                context.Update(FindOrderDetail);
            }
            else
            {
                orderDetail.UnitPrice = CalculateMoney(product.PricePerUnit, orderDetail.Discount, orderDetail.Quantity);

                context.Add(orderDetail);
            }

            return context.SaveChanges();
        }

        public int DeleteOrderDetail(int OrderId, int ProductId)
        {
            var OrderDetail = context.OrderDetails.FirstOrDefault(el =>
                                el.OrderId == OrderId &&
                                el.ProductId == ProductId);
            context.Remove(OrderDetail);
            return context.SaveChanges();
        }

        public List<Product> GetListProductByCategoryId(int id) =>
             context.Products.ToList().FindAll(el => el.CategoryId == id);

        public Order GetOrderByid(int id) =>
            context.Orders.FirstOrDefault(el => el.Id == id);

        public OrderDetail GetOrderDetailByIds(int ProductId, int OrderId)
        {
            var orderdetail = context.OrderDetails.FirstOrDefault(el =>
                                el.ProductId == ProductId &&
                                el.OrderId == OrderId);
            return (orderdetail);
        }

        public Product GetProductById(int id) =>
            context.Products.FirstOrDefault(el => el.Id == id);

        public int UpdateOrderDetail(OrderDetail orderDetail)
        {
            context.Update(orderDetail);
            return context.SaveChanges();
        }
    }
}
