using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class CategoryVariationRequestModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public string VariationName { get; set; }
    }
}
