using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryContracts
{
    public interface IReviewRepositoryAsync : IRepositoryAsync<Review>
    {
        Task<IEnumerable<Review>> GetReviewByProductIdAsync(int id);

        Task<IEnumerable<Review>> GetReviewByCustomerIdAsync(int id);
    }
}
