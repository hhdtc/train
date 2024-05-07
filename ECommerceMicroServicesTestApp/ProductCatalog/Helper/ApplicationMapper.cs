using AutoMapper;
using ProductCatalog.ApplicationCore.Entity;
using ProductCatalog.ApplicationCore.Model.RequestModel;
using ProductCatalog.ApplicationCore.Model.ResponseModel;

namespace ProductCatalog.Helper
{
    public class ApplicationMapper: Profile{
        public ApplicationMapper() {
            CreateMap<ProductRequestModel, Product>().ReverseMap();
            CreateMap<ProductResponseModel, Product>().ReverseMap();

            CreateMap<CategoryRequestModel, Category>().ReverseMap();
            CreateMap<CategoryResponseModel, Category>().ReverseMap();
        }
    }
}
