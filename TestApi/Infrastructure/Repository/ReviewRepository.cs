using ApplicationCore.Entities;
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
    public class ReviewRepositoryAsync : BaseRepositoryAsync<Review>, IReviewRepositoryAsync
    {
        public ReviewRepositoryAsync(EcommerceDbContext c) : base(c)
        {
        }

        public async Task<IEnumerable<Review>> GetReviewByCustomerIdAsync(int id)
        {
            return await _context.Set<Review>().Where(r => r.CustomerId == id).ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetReviewByProductIdAsync(int id)
        {
            return await _context.Set<Review>().Where(r => r.ProductId == id).ToListAsync();
        }
    }
}
