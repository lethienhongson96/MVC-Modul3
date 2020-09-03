using Microsoft.AspNetCore.Http;
using StoreManagement.Models.Entities;
using StoreManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public interface IProductService
    {
        int CreateProduct(CreateProductView productView);

        string UploadedFile(IFormFile formFile);

        List<Product> GetProductList();

        int DeleteProduct(int id);

        EditProductView FindProductToView(int id);

        int UpdateProduct(EditProductView productView);
    }
}
