using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using AutoMapper;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class CategoryServiceAsync : ICategoryServiceAsync
    {
        private readonly ICategoryRepositoryAsync categoryRepository;
        private readonly IMapper _mapper;
        public CategoryServiceAsync(ICategoryRepositoryAsync repo, IMapper mapper)
        {
            categoryRepository = repo;
            _mapper = mapper;
        }


        public async Task<int> DeleteCategoryAsync(int id)
        {
            return await categoryRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoryResponseModel>> GetAllCategoriesAsync()
        {
            List<CategoryResponseModel> lst= new List<CategoryResponseModel>();
            var collection = await categoryRepository.GetAllAsync();
            if(collection != null)
            {
                /*
                foreach (var item in collection)
                {
                    CategoryResponseModel m = new CategoryResponseModel();
                    m.Id= item.Id;
                    m.CategoryName = item.CategoryName;
                    lst.Add(m);
                }
                return lst;
                */
                return _mapper.Map<IEnumerable<CategoryResponseModel>>(collection);
            }
            return null;
        }

        public async Task<CategoryResponseModel> GetCategoryByIdAsync(int id)
        {
            var category = await categoryRepository.GetByIdAsync(id);
            if (category != null)
            {
                /*
             CategoryResponseModel categoryResponseModel = new CategoryResponseModel();
                categoryResponseModel.Id = category.Id;
                categoryResponseModel.CategoryName = category.CategoryName;
                return categoryResponseModel;
                */
                return _mapper.Map< CategoryResponseModel > (category);
            }
            return null;
        }

        public async Task<int> InsertCategoryAsync(CategoryRequestModel category)
        {
            /*
            Category c = new Category() {
                CategoryName = category.CategoryName,
            };
            */

            Category c = _mapper.Map< Category>(category);

           return await categoryRepository.InsertAsync(c);
        }

        public async Task<int> UpdateCategoryAsync (CategoryRequestModel category, int id)
        {
            /*
            Category c = new Category() { 
            CategoryName = category.CategoryName,
            Id = id
            };
            */
            Category c = _mapper.Map<Category>(category);

            return await categoryRepository.UpdateAsync(c);
        }

    }
}
