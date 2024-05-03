using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Category : HasId
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        public int? ParentCategoryId { get; set; }
        
        public Category ParentCategory { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();     
    }
}
