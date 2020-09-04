using StoreManagement.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models.Entities
{
    public class OrderDetail
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }
        public double Discount{ get; set; }
        public double UnitPrice { get; set; }
        public PayStatus PayStatus{ get; set; }
    }
}
