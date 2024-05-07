using AutoMapper;
using Order.ApplicationCore.Entity;
using Order.ApplicationCore.Model.RequestModel;
using Order.ApplicationCore.Model.ResponseModel;
using OrderApi.model;

namespace OrderApi.helper
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<OrderRequestModel, Orders>().ReverseMap();
            CreateMap<OrderResponseModel, Orders>().ReverseMap();
            CreateMap<OrderDetailResponseModel, OrderDetail>().ReverseMap();
            CreateMap<OrderDetailRequestModel, OrderDetail>().ReverseMap();
        }

    }
}
