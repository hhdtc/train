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
    public class ShoppingCartRepositoryAsync : BaseRepositoryAsync<Category>, ICategoryRepositoryAsync
    {
        public ShoppingCartRepositoryAsync(EcommerceDbContext c) : base(c)
        {
        }
    }
}
