using StoreManagement.Models.Entities;
using StoreManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public interface ICategoryService
    {
        int CreateCategory(Category category);

        IEnumerable<Category> GetCategories();

        Category GetCategoryById(int id);

        int UpdateCategory(Category category);

        int DeleteCategory(int id);

        int MoveCategoryForProduct(int id);

        List<MoveDefaultView> GetListMoveDefaultViewByCateId(int id);

        int MoveRangeCategoryForProduct(List<Product> products);

        Product GetProductById(int id);
    }
}
