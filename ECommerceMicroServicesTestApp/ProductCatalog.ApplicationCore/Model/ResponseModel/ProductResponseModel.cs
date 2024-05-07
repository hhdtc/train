using ProductCatalog.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.ApplicationCore.Model.ResponseModel
{
    public class ProductResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public string Description { get; set; } = string.Empty;

        public decimal Qty { get; set; } = decimal.Zero;

        public string ProductImage { get; set; } = string.Empty;

        public string SKU { get; set; } = string.Empty;
    }
}
