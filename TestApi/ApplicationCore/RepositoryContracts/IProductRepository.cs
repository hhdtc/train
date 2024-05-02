using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryContracts
{
    public interface IProductRepositoryAsync : IRepositoryAsync<Product>
    {
        //public IEnumerable<Product> GetAllWithCategory();
        public Task<IEnumerable<Product>> GetAllWithCategoryAsync(int categoryId, int pageNumber, int pageSize);
    }
}
