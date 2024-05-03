using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Model.Response
{
    public class ProductVariationValuesResponseModel
    {

        public int ProductId { get; set; }

        public int VariationValueId { get; set; }

    }
}
