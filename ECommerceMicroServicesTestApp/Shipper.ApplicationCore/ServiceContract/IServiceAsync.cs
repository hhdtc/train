using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.ApplicationCore.ServiceContract
{
    public interface IService<Model, Request, Response>
    {
        Task<IEnumerable<Response>> GetAllAsync();
        Task<int> InsertAsync(Request r);
        Task<int> UpdateAsync(Request r, int id);
        Task<int> DeleteAsync(int id);
        Task<Response> GetByIdAsync(int id);

        Task<IEnumerable<Response>> GetAllByFilterAsync(Func<Model, bool> condition);

        Response GetFirstByFilterAsync(Func<Model, bool> condition);
    }
}
