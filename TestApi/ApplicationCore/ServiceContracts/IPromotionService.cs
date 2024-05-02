using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IPromotionServiceAsync
    {
        Task<IEnumerable<PromotionResponseModel>> GetAllPromotionAsync();
        Task<int> InsertPromotionAsync(PromotionRequestModel promotion);
        Task<int> UpdatePromotionAsync(PromotionRequestModel promotion, int id);
        Task<int> DeletePromotionAsync(int id);
        Task<PromotionResponseModel> GetPromotionByIdAsync(int id);
    }
}
