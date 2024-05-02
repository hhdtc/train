using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IService<Request,Response>
    {
        IEnumerable<Response> GetAllAsync();
        int InsertAsync(Request r);
        int UpdateAsync(Request r);
        int DeleteAsync(int id);
        Response GetByIdAsync(int id);
    }
}
