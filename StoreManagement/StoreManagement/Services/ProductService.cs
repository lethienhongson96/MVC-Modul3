using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using StoreManagement.Models;
using StoreManagement.Models.Entities;
using StoreManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StoreManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductService(StoreDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this._context = context;
            this._webHostEnvironment = webHostEnvironment;
        }

        public int CreateProduct(CreateProductView productView)
        {
            Product product = new Product()
            {
                Name = productView.Name,
                QuantityPerUnit = productView.Price,
                CreateAt = productView.CreateAt,
                Status = productView.Status,
                ImagePath = UploadedFile(productView.IformfilePath),
                CategoryId = productView.CategoryId
            };
            _context.Products.Add(product);

            return (_context.SaveChanges());
        }

        public int DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(el => el.Id == id);

            if (product != null)
            {
                if (!string.IsNullOrEmpty(product.ImagePath))
                {
                    string DelPath = Path.Combine(_webHostEnvironment.WebRootPath, "Images", product.ImagePath);
                    File.Delete(DelPath);
                }
                _context.Products.Remove(product);

                return _context.SaveChanges();
            }
            return -1;
        }

        public EditProductView FindProductToView(int id)
        {
            var product = _context.Products.FirstOrDefault(el => el.Id == id);

            var productview = new EditProductView()
            {
                id = product.Id,
                Name = product.Name,
                Price = product.QuantityPerUnit,
                CreateAt = product.CreateAt,
                Status = product.Status,
                CategoryId = product.CategoryId,
                imgPath = product.ImagePath
            };

            return productview;
        }

        public List<Product> GetProductList()
        {
            return (_context.Products.ToList());
        }

        public int UpdateProduct(EditProductView productView)
        {
            var product = _context.Products.FirstOrDefault(el => el.Id == productView.id);

            product.Name = productView.Name;
            product.CategoryId = productView.CategoryId;
            product.CreateAt = productView.CreateAt;
            product.QuantityPerUnit = productView.Price;
            product.Status = productView.Status;

            if (productView.IformfilePath != null)
            {
                product.ImagePath = UploadedFile(productView.IformfilePath);

                if (!string.IsNullOrEmpty(productView.imgPath))
                {
                    string DelPath = Path.Combine(_webHostEnvironment.WebRootPath, "Images", productView.imgPath);
                    File.Delete(DelPath);
                }
            }

            _context.Update(product);
            return (_context.SaveChanges());
        }

        public string UploadedFile(IFormFile formFile)
        {
            string uniqueFileName = null;

            if (formFile != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                formFile.CopyTo(fileStream);
            }
            return uniqueFileName;
        }
    }
}
