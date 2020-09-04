
using StoreManagement.Models;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public class OrderService : IOrderService
    {
        private readonly StoreDbContext _context;

        public OrderService(StoreDbContext context)
        {
            this._context = context;
        }
        public int CreateOrder(Order order)
        {
            _context.Add(order);
            return (_context.SaveChanges());
        }

        public int DeleteOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(el => el.Id == id);

            if (order == null)
                return -1;
            _context.Remove(order);

            return _context.SaveChanges();
        }

        public Order GetOrder(int id)
        {
            return _context.Orders.FirstOrDefault(el => el.Id == id);
        }

        public List<Order> GetOrderList()
        {
            return _context.Orders.ToList();
        }

        public int UpdateOrder(Order order)
        {
            _context.Update(order);
            return _context.SaveChanges();
        }
    }
}
