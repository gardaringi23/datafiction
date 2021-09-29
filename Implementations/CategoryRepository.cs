using System;
using System.Collections.Generic;
using System.Linq;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;
using Datafication.Repositories.Contexts;
using Datafication.Repositories.Entities;
using Datafication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Datafication.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IceCreamDbContext _dbContext;

        public CategoryRepository(IceCreamDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CategoryDto CreateNewCategory(CategoryInputModel categoryId)
        {
            var category = _dbContext.Categories.FirstOrDefault(u =>
            u.)
        }
    }
}