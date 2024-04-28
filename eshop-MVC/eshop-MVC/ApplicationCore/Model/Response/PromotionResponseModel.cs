using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Response
{
    public class PromotionResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public decimal Discount { get; set; }
    }
}
