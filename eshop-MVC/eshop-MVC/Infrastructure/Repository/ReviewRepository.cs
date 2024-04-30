using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ReviewRepository: BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(EcommerceDbContext c) : base(c)
        {
        }

        public IEnumerable<Review> GetReviewByCustomerId(int id)
        {
            return _context.Set<Review>().Where(r => r.CustomerId == id);
        }

        public IEnumerable<Review> GetReviewByProductId(int id)
        {
            return _context.Set<Review>().Where(r => r.ProductId == id);
        }
    }
}
