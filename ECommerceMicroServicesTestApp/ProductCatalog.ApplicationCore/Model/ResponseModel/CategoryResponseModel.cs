using ProductCatalog.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.ApplicationCore.Model.ResponseModel
{
    public class CategoryResponseModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        public int? ParentCategoryId { get; set; }


    }
}
