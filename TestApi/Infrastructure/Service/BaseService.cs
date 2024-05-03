using ApplicationCore.Entities;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class BaseService<Model,Request, Response> : IService< Model, Request, Response> where Model : class, HasId
        where Request: class
        where Response : class
    {
        protected readonly IRepositoryAsync<Model> _repo;
        protected readonly IMapper _mapper;
        public BaseService(IRepositoryAsync<Model> repository, IMapper mapper) {
            _repo = repository;
            _mapper = mapper;
        }
        public async Task<int> DeleteAsync(int id)
        {
            return await _repo.DeleteAsync(id); ;
        }

        public async Task<IEnumerable<Response>> GetAllAsync()
        {
            var result = await _repo.GetAllAsync();
            if (result != null)
            {
                return _mapper.Map<IEnumerable<Response>>(result);
            }
            else
            {
                return null;
            }
        }

        public async Task<Response> GetByIdAsync(int id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result != null)
            {
                return _mapper.Map<Response>(result);
            }
            return null;
        }

        public async Task<int> InsertAsync(Request requestModel)
        {
            Model model = _mapper.Map<Model>(requestModel);

            return await _repo.InsertAsync(model);
        }

        public async Task<int> UpdateAsync(Request requestModel, int id)
        {
            var model = _mapper.Map<Model>(requestModel);
            model.Id = id;
            return await _repo.UpdateAsync(model);
        }
    }
}
