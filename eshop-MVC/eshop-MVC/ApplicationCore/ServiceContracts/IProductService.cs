using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IProductService
    {
        IEnumerable<ProductResponseModel> GetAllProducts();
        int InsertProduct(ProductRequestModel category);
        int UpdateProduct(ProductRequestModel category);
        int DeleteProduct(int id);
        ProductResponseModel GetProductById(int id);
    }
}
