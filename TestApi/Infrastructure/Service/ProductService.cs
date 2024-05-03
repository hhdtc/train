using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using AutoMapper;
using Infrastructure.Repository;
using Infrastructure.Service;

namespace ApplicationCore.ServiceContracts
{
    public class ProductServiceAsync : IProductServiceAsync
    {

        private readonly IProductRepositoryAsync productRepository;
        private readonly IMapper _mapper;

        public ProductServiceAsync(IProductRepositoryAsync repo, IMapper mapper)
        {
            productRepository = repo;
            _mapper = mapper;
        }
        public async Task<int> DeleteProductAsync(int id)
        {
            return await productRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductResponseModel>> GetAllProductsAsync()
        {
            List<ProductResponseModel> lst = new List<ProductResponseModel>();
            var collection = await productRepository.GetAllAsync();
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    ProductResponseModel m = new ProductResponseModel();
                    m.Id = item.Id;
                    m.Name = item.Name;
                    m.CategoryId = item.CategoryId;
                    m.Price = item.Price;
                    //m.CategoryName = item.Category.CategoryName;
                    //m.CategoryName = "";
                    lst.Add(m);
                }
                return lst;

                //return _mapper.Map<IEnumerable<ProductResponseModel>>(collection);
            }
            return null;
        }

        public async Task<ProductResponseModel> GetProductByIdAsync(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            if (product != null)
            {
                ProductResponseModel productResponseModel = new ProductResponseModel();
                productResponseModel.Id = product.Id;
                productResponseModel.CategoryId = product.CategoryId;
                productResponseModel.Price = product.Price;
                //productResponseModel.CategoryName = product.Category.CategoryName;
                return productResponseModel;

                return _mapper.Map<ProductResponseModel>(product);
            }


            return null;
        }

        public async Task<int> InsertProductAsync(ProductRequestModel product)
        {
            Product p = new Product()
            {
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId,
            };


            return await productRepository.InsertAsync(p);
        }

        public async Task<int> UpdateProductAsync(ProductRequestModel product, int id)
        {
            Product c = new Product()
            {
                Id = id,
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId,
            };
            return await productRepository.UpdateAsync(c);
        }

        public async Task<IEnumerable<SelectListItem>> GetSelectItemAsync(){

            var all = await productRepository.GetAllAsync();
            return all.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }

        public async Task<IEnumerable<ProductResponseModel>> GetProductPageAsync(int categoryId, int pageNum, int pageSize) {
            var all = await productRepository.GetAllWithCategoryAsync(categoryId,pageNum,pageSize);
            return _mapper.Map<IEnumerable<ProductResponseModel>>(all);
        }
    }
}
