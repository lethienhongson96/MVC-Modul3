using StoreManagement.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreateAt { get; set; }
        public string ImagePath { get; set; }
        public Status Status { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
