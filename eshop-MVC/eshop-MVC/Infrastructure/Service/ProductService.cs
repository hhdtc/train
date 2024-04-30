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
    public class ProductService : IProductService
    {

        private readonly IProductRepository productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repo, IMapper mapper)
        {
            productRepository = repo;
            _mapper = mapper;
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
                    m.Name = item.Name;
                    m.CategoryId = item.CategoryId;
                    m.Price = item.Price;
                    //m.CategoryName = item.Category.CategoryName;
                    m.CategoryName = "";
                    lst.Add(m);
                }
                return lst;

                //return _mapper.Map<IEnumerable<ProductResponseModel>>(collection);
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

                return _mapper.Map<ProductResponseModel>(product);
            }


            return null;
        }

        public int InsertProduct(ProductRequestModel product)
        {
            Product p = new Product()
            {
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId,
            };


            return productRepository.Insert(p);
        }

        public int UpdateProduct(ProductRequestModel product)
        {
            Product c = new Product()
            {
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId,
            };
            return productRepository.Update(c);
        }

        public IEnumerable<SelectListItem> GetSelectItem(){
            return productRepository.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }
    }
}
