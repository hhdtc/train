using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System.Web.Mvc;

namespace ApplicationCore.ServiceContracts
{
    public interface IProductServiceAsync
    {
        Task<IEnumerable<ProductResponseModel>> GetAllProductsAsync();
        Task<int> InsertProductAsync(ProductRequestModel category);
        Task<int> UpdateProductAsync(ProductRequestModel category, int id);
        Task<int> DeleteProductAsync(int id);
        Task<ProductResponseModel> GetProductByIdAsync(int id);

        Task<IEnumerable<SelectListItem>> GetSelectItemAsync();
    }
}
