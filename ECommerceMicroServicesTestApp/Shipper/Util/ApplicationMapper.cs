using AutoMapper;
using Shipper.ApplicationCore.Entity;
using Shipper.ApplicationCore.Model.RequestModel;
using Shipper.ApplicationCore.Model.ResponseModel;

namespace Shipper.Util
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() {
            CreateMap<ShipperRequestModel, Shippers>().ReverseMap();
            CreateMap<ShipperResponseModel, Shippers>().ReverseMap();

            CreateMap<RegionRequestModel, Region>().ReverseMap();
            CreateMap<RegionResponseModel,Region>().ReverseMap();
        }

    }
}
