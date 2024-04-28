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
        IEnumerable<Response> GetAll();
        int Insert(Request r);
        int Update(Request r);
        int Delete(int id);
        Response GetById(int id);
    }
}
