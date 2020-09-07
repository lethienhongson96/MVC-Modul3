using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public interface IOrderDetailService
    {
        Order GetOrderByid(int id);

        OrderDetail CreateByOrderId(int id);

        int CreateOrderDetail(OrderDetail orderDetail);

        List<Product> GetListProductByCategoryId(int id);

        double CalculateMoney(double PriceProduct,double Percent,int Quantity);
    }
}
