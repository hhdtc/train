using DapperTutorial.Core.Entities;
using DapperTutorial.Core.ServiceContract;
using DapperTutorial.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.Infrastructure.Service
{
    internal class RevieService : IService<Review>
    {
        ReviewRepository rp = new ReviewRepository();
        public int DeleteById(int id)
        {
            return rp.DeleteById(id);
        }

        public List<Review> GetAll()
        {
            return rp.GetAll().ToList();
        }

        public Review GetById(int id)
        {
            return rp.GetById(id);
        }

        public int Insert(Review t)
        {
            return rp.Insert(t);
        }

        public int Update(Review t)
        {
            return rp.Update(t);
        }
    }
}
