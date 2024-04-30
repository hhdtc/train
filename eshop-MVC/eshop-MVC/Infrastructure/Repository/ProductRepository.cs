using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(EcommerceDbContext c) : base(c)
        {

        }

        /*
        public IEnumerable<Product> GetAllWithCategory()
        {
            return _context.Set<Product>().F ToList();
        }
        */
    }
}
