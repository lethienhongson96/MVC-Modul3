using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public interface IOrderService
    {
        int CreateOrder(Order order);

        List<Order> GetOrderList();

        int DeleteOrder(int id);

        Order GetOrder(int id);

        int UpdateOrder(Order order);
    }
}
