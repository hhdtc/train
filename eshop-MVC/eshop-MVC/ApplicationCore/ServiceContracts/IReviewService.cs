using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IReviewService
    {
        IEnumerable<ReviewResponseModel> GetAllReview();
        int InsertReview(ReviewRequestModel review);
        int UpdateReview(ReviewRequestModel review);
        int DeleteReview(int id);
        ReviewResponseModel GetReviewbyId(int id);

        IEnumerable<ReviewResponseModel> GetReviewByProductId(int id);

        IEnumerable<ReviewResponseModel> GetReviewByCustomerId(int id);
    }
}
