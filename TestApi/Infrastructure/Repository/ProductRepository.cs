﻿using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductRepositoryAsync : BaseRepositoryAsync<Product>, IProductRepositoryAsync
    {
        public ProductRepositoryAsync(EcommerceDbContext c) : base(c)
        {

        }

        
        public async Task<IEnumerable<Product>> GetAllWithCategoryAsync(int categoryId, int pageNumber, int pageSize)
        {
            return await _context.Set<Product>().Skip(pageNumber-1).Take(pageSize).ToListAsync();
        }
        
    }
}
