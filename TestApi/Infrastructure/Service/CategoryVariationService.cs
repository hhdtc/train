using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using AutoMapper;
using Infrastructure.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class CategoryVariationService : IService<CategoryVariation ,CategoryVariationRequestModel, CategoryVariationResponseModel>
    {

        private readonly ICategoryVariationRepositoryAsync _repo;
        private readonly IMapper _mapper;
        public CategoryVariationService(ICategoryVariationRepositoryAsync repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<int> DeleteAsync(int id)
        {
            return await _repo.DeleteAsync(id); ;
        }

        public async Task<IEnumerable<CategoryVariationResponseModel>> GetAllAsync()
        {
            var result = await _repo.GetAllAsync();
            if (result != null)
            {
                return _mapper.Map<IEnumerable<CategoryVariationResponseModel>>(result);
            }
            else
            {
                return null;
            }
        }

        public async Task<CategoryVariationResponseModel> GetByIdAsync(int id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result != null)
            {
                return _mapper.Map<CategoryVariationResponseModel>(result);
            }
            return null;
        }

        public async Task<int> InsertAsync(CategoryVariationRequestModel requestModel)
        {
            CategoryVariation model = _mapper.Map<CategoryVariation>(requestModel);

            return await _repo.InsertAsync(model);
        }

        public async Task<int> UpdateAsync(CategoryVariationRequestModel requestModel, int id)
        {
            var model = _mapper.Map<CategoryVariation>(requestModel);
            model.Id = id;
            return await _repo.UpdateAsync(model);
        }
    }
}
