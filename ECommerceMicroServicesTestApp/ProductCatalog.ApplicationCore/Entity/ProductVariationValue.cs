using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.ApplicationCore.Entity
{
    [PrimaryKey(nameof(ProductId), nameof(VariationValueId))]
    public class ProductVariationValues
    {

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int VariationValueId { get; set; }
        public VariationValue VariationValue { get; set; }

    }
}
