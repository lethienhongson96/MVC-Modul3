using Microsoft.AspNetCore.Http;
using StoreManagement.Enum;
using System;

namespace StoreManagement.Models.ViewModels
{
    public class CreateProductView
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy{ get; set; }
        public IFormFile IformfilePath { get; set; }
        public Status Status { get; set; }

        public int CategoryId { get; set; }
    }
}
