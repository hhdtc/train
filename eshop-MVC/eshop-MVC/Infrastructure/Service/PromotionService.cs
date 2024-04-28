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
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository promotionRepository;
        public PromotionService(IPromotionRepository repo)
        {
            promotionRepository = repo;
        }

        public int DeletePromotion(int id)
        {
            return promotionRepository.Delete(id);
        }

        public IEnumerable<PromotionResponseModel> GetAllPromotion()
        {
            List<PromotionResponseModel> lst = new List<PromotionResponseModel>();
            var collection = promotionRepository.GetAll();
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

        public PromotionResponseModel GetPromotionById(int id)
        {
            var shipper = promotionRepository.GetById(id);
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

        public int InsertPromotion(PromotionRequestModel promotion)
        {
            Promotion p = new Promotion()
            {
                Name = promotion.Name,
                Discount = promotion.Discount,

            };

            return promotionRepository.Insert(p);
        }

        public int UpdatePromotion(PromotionRequestModel promotion)
        {
            Promotion c = new Promotion()
            {
                Name = promotion.Name,
                Discount = promotion.Discount,
            };
            return promotionRepository.Update(c);
        }


    }
}
