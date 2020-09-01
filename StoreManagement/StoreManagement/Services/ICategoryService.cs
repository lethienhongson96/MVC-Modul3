using StoreManagement.Models.Entities;
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
    }
}
