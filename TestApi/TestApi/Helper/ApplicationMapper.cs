using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using AutoMapper;
using Infrastructure.Migrations;

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

            CreateMap<CategoryVariationRequestModel, CategoryVariation>().ReverseMap();
            CreateMap<CategoryVariationResponseModel, CategoryVariation>().ReverseMap();


            CreateMap<CustomerRequestModel, Customer>().ReverseMap();
            CreateMap<CustomerResponseModel, Customer>().ReverseMap();


            CreateMap<OrderRequestModel, Order>().ReverseMap();
            CreateMap<OrderResponseModel, Order>().ReverseMap();


            CreateMap<OrderDetailRequestModel, OrderDetail>().ReverseMap();
            CreateMap<OrderDetailResponseModel, OrderDetail>().ReverseMap();


            CreateMap<PaymentMethodRequestModel, PaymentMethod>().ReverseMap();
            CreateMap<PaymentMethodResponseModel, PaymentMethod>().ReverseMap();


            CreateMap<PaymentTypeRequestModel, PaymentType>().ReverseMap();
            CreateMap<PaymentTypeResponseModel, PaymentType>().ReverseMap();


            CreateMap<ProductRequestModel, Product>().ReverseMap();
            CreateMap<ProductResponseModel, Product>().ReverseMap();


            CreateMap<ProductVariationValuesRequestModel, ProductVariationValues>().ReverseMap();
            CreateMap<ProductVariationValuesResponseModel, ProductVariationValues>().ReverseMap();


            CreateMap<PromotionRequestModel, Promotion>().ReverseMap();
            CreateMap<PromotionResponseModel, Promotion>().ReverseMap();


            CreateMap<PromotionDetailRequestModel, PromotionDetail>().ReverseMap();
            CreateMap<PromotionDetailResponseModel, PromotionDetail>().ReverseMap();


            CreateMap<RegionRequestModel, Region>().ReverseMap();
            CreateMap<RegionResponseModel, Region>().ReverseMap();


            CreateMap<ReviewRequestModel, Review>().ReverseMap();
            CreateMap<ReviewResponseModel, Review>().ReverseMap();


            CreateMap<RoleRequestModel, Role>().ReverseMap();
            CreateMap<RoleResponseModel, Role>().ReverseMap();


            CreateMap<ShipperRequestModel, Shipper>().ReverseMap();
            CreateMap<ShipperResponseModel, Shipper>().ReverseMap();


            CreateMap<ShipperRegionRequestModel, ShipperRegion>().ReverseMap();
            CreateMap<ShipperRegionResponseModel, ShipperRegion>().ReverseMap();


            CreateMap<ShoppingCartRequestModel, ShoppingCart>().ReverseMap();
            CreateMap<ShoppingCartResponseModel, ShoppingCart>().ReverseMap();


            CreateMap<ShoppingCartItemRequestModel, ShoppingCartItem>().ReverseMap();
            CreateMap<ShoppingCartItemResponseModel, ShoppingCartItem>().ReverseMap();


            CreateMap<UserAddressRequestModel, UserAddress>().ReverseMap();
            CreateMap<UserAddressResponseModel, UserAddress>().ReverseMap();

            CreateMap<UserRoleRequestModel, UserRole>().ReverseMap();
            CreateMap<UserRoleResponseModel, UserRole>().ReverseMap();

            CreateMap<VariationValueRequestModel, VariationValue>().ReverseMap();
            CreateMap<VariationValueResponseModel, VariationValue>().ReverseMap();

        }
    }
}