using StoreManagement.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status{ get; set; }
        public DateTime CreateAt { get; set; }

        public string CreateBy { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public List<Product> Products { get; set; }
    }
}
