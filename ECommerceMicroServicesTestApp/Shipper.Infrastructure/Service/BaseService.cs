using AutoMapper;
using Shipper.ApplicationCore.Entity;
using Shipper.ApplicationCore.RepositoryContract;
using Shipper.ApplicationCore.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.Infrastructure.Service
{
    public class BaseService<Model, Request, Response> : IService<Model, Request, Response> where Model : class, HasId
        where Request : class
        where Response : class
    {
        protected readonly IRepositoryAsync<Model> _repo;
        protected readonly IMapper _mapper;
        public BaseService(IRepositoryAsync<Model> repository, IMapper mapper)
        {
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

        public async Task<IEnumerable<Response>> GetAllByFilterAsync(Func<Model, bool> condition)
        {
            var result = await _repo.GetAllByFilterAsync(condition);
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

        public Response GetFirstByFilterAsync(Func<Model, bool> condition)
        {
            var result = _repo.GetFirstByFilterAsync(condition);
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
