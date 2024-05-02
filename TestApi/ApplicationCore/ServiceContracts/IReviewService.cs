using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IReviewServiceAsync
    {
        Task<IEnumerable<ReviewResponseModel>> GetAllReviewAsync();
        Task<int> InsertReviewAsync(ReviewRequestModel review);
        Task<int> UpdateReviewAsync(ReviewRequestModel review, int id);
        Task<int> DeleteReviewAsync(int id);
        Task<ReviewResponseModel> GetReviewbyIdAsync(int id);

        Task<IEnumerable<ReviewResponseModel>> GetReviewByProductIdAsync(int id);

        Task<IEnumerable<ReviewResponseModel>> GetReviewByCustomerIdAsync(int id);
    }
}
