using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IPromotionService
    {
        IEnumerable<PromotionResponseModel> GetAllPromotion();
        int InsertPromotion(PromotionRequestModel promotion);
        int UpdatePromotion(PromotionRequestModel promotion);
        int DeletePromotion(int id);
        PromotionResponseModel GetPromotionById(int id);
    }
}
