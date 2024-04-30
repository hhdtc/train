using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System.Web.Mvc;

namespace ApplicationCore.ServiceContracts
{
    public interface IProductService
    {
        IEnumerable<ProductResponseModel> GetAllProducts();
        int InsertProduct(ProductRequestModel category);
        int UpdateProduct(ProductRequestModel category);
        int DeleteProduct(int id);
        ProductResponseModel GetProductById(int id);

        IEnumerable<SelectListItem> GetSelectItem();
    }
}
