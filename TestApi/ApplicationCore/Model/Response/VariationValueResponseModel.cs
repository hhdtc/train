using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Response
{
    public class VariationValueResponseModel
    {
        public int Id { get; set; }
        public int VariationId { get; set; }

        public int value { get; set; }
    }
}
