using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using Infrastructure.Repository;

namespace ApplicationCore.ServiceContracts
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository repo)
        {
            productRepository = repo;
        }
        public int DeleteProduct(int id)
        {
            return productRepository.Delete(id);
        }

        public IEnumerable<ProductResponseModel> GetAllProducts()
        {
            List<ProductResponseModel> lst = new List<ProductResponseModel>();
            var collection = productRepository.GetAll();
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    ProductResponseModel m = new ProductResponseModel();
                    m.Id = item.Id;
                    m.CategoryId = item.CategoryId;
                    m.Price = item.Price;
                    m.CategoryName = item.Category.CategoryName;
                    lst.Add(m);
                }
                return lst;
            }
            return null;
        }

        public ProductResponseModel GetProductById(int id)
        {
            var product = productRepository.GetById(id);
            if (product != null)
            {
                ProductResponseModel productResponseModel = new ProductResponseModel();
                productResponseModel.Id = product.Id;
                productResponseModel.CategoryId = product.CategoryId;
                productResponseModel.Price = product.Price;
                productResponseModel.CategoryName = product.Category.CategoryName;
                return productResponseModel;
            }
            return null;
        }

        public int InsertProduct(ProductRequestModel product)
        {
            Product p = new Product()
            {
                Name = product.Name,
                Price = product.Price,

            };

            return productRepository.Insert(p);
        }

        public int UpdateProduct(ProductRequestModel product)
        {
            Product c = new Product()
            {
                Name = product.Name,
                Price = product.Price,
            };
            return productRepository.Update(c);
        }
    }
}
