using StoreManagement.Models;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;

        public ProductService(StoreDbContext context)
        {
            this._context = context;
        }


        public int CreateProduct(Product product)
        {
            _context.Products.Add(product);
            return (_context.SaveChanges());
        }
    }
}
