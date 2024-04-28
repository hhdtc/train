using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.Core.ServiceContract
{
    public interface IService<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        int Update(T t);
        int DeleteById(int id);

        int Insert(T t);

    }
}
