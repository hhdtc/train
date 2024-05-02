using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class PromotionServiceAsync : IPromotionServiceAsync
    {
        private readonly IPromotionRepositoryAsync promotionRepository;
        public PromotionServiceAsync(IPromotionRepositoryAsync repo)
        {
            promotionRepository = repo;
        }

        public async Task<int> DeletePromotionAsync(int id)
        {
            return await promotionRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PromotionResponseModel>> GetAllPromotionAsync()
        {
            List<PromotionResponseModel> lst = new List<PromotionResponseModel>();
            var collection = await promotionRepository.GetAllAsync();
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    PromotionResponseModel m = new PromotionResponseModel();
                    m.Id = item.Id;
                    m.Name = item.Name;
                    m.Discount = item.Discount;
                    lst.Add(m);
                }
                return lst;
            }
            return null;
        }

        public async Task<PromotionResponseModel> GetPromotionByIdAsync(int id)
        {
            var shipper =await promotionRepository.GetByIdAsync(id);
            if (shipper != null)
            {
                PromotionResponseModel promotionResponseModel = new PromotionResponseModel();
                promotionResponseModel.Id = shipper.Id;
                promotionResponseModel.Name = shipper.Name;
                promotionResponseModel.Discount = shipper.Discount;
                return promotionResponseModel;
            }
            return null;
        }

        public async Task<int> InsertPromotionAsync(PromotionRequestModel promotion)
        {
            Promotion p = new Promotion()
            {
                Name = promotion.Name,
                Discount = promotion.Discount,

            };

            return await promotionRepository.InsertAsync(p);
        }

        public async Task<int> UpdatePromotionAsync(PromotionRequestModel promotion, int id)
        {
            Promotion c = new Promotion()
            {
                Id = id,
                Name = promotion.Name,
                Discount = promotion.Discount,
            };
            return await promotionRepository.UpdateAsync(c);
        }


    }
}
