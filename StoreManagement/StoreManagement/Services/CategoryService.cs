﻿using StoreManagement.Models;
using StoreManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly StoreDbContext _context;

        public CategoryService(StoreDbContext context)
        {
            this._context = context;
        }

        public int CreateCategory(Category category)
        {
            _context.Add(category);
            return (_context.SaveChanges());
        }

        public IEnumerable<Category> GetCategories()
        {
            return (_context.Categories.ToList());
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.ToList().Find(el=>el.Id==id);
        }

        public int UpdateCategory(Category category)
        {
            if (category==null)
            {
                return -1;
            }
            _context.Update(category);
            return _context.SaveChanges();
        }
    }
}
