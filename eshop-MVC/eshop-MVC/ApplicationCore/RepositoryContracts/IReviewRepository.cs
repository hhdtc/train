using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryContracts
{
    public interface IReviewRepository: IRepository<Review>
    {
        public IEnumerable<Review> GetReviewByProductId(int id);

        public IEnumerable<Review> GetReviewByCustomerId(int id);
    }
}
