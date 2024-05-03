using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class PaymentMethodRequestModel
    {
        public int Id { get; set; }
        public int PaymentTyepId { get; set; }

        public string Provider { get; set; }

        public decimal AccountNumber { get; set; }

        public DateTime Expiry { get; set; }

        public bool IsDefault { get; set; }
    }
}
