using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class BaseService<Repository,Model,Request, Response> : IService<Repository,Request, Response> where Model : class
    {
        protected readonly IRepositoryAsync<Model> _repository;
        public BaseService(IRepositoryAsync<Model> repository) {
            _repository = repository;
        }
        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Response>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Request r)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Request r, int id)
        {
            throw new NotImplementedException();
        }
    }
}
