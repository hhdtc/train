using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CategoryVariationRepositoryAsync: BaseRepositoryAsync<CategoryVariation>, ICategoryVariationRepositoryAsync
    {
        public CategoryVariationRepositoryAsync(EcommerceDbContext c) : base(c)
        {
        }
    }
}
