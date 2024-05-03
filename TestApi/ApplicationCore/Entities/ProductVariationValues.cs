using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Entities
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
