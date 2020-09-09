using StoreManagement.Enum;
using System;
using System.Collections.Generic;

namespace StoreManagement.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public PayStatus PayStatus { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ShipperDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser{ get; set; }
    }
}
