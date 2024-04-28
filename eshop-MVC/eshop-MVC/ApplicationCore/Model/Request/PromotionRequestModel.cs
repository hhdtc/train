using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class PromotionRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public decimal Discount { get; set; }
    }
}
