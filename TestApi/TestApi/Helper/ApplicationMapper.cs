using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using AutoMapper;

namespace Infrastructure.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<ProductRequestModel, Product>().ReverseMap();
            //CreateMap<Product, ProductRequestModel>();
            CreateMap<ProductResponseModel, Product>().ReverseMap();

            CreateMap<ReviewRequestModel, Review>().ReverseMap();
            CreateMap<ReviewResponseModel, Review>().ReverseMap();


        }
    }
}