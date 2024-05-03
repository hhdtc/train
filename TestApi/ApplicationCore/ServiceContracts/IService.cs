using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IService<Repository,Request, Response>
    {
        Task<IEnumerable<Response>> GetAllAsync();
        Task<int> InsertAsync(Request r);
        Task<int> UpdateAsync(Request r,int id);
        Task<int> DeleteAsync(int id);
        Task<Response> GetByIdAsync(int id);
    }
}
