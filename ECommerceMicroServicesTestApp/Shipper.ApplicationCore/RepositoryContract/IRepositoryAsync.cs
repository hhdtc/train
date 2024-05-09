using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.ApplicationCore.RepositoryContract
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<int> InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllByFilterAsync(Func<T, bool> condition);

        T GetFirstByFilterAsync(Func<T, bool> condition);
    }
}
