using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.ApplicationCore.Entity
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public int PaymentTyepId { get; set; }

        public PaymentType PaymentType { get; set; }

        public string Provider { get; set; }

        public decimal AccountNumber { get; set; }

        public DateTime Expiry { get; set; }

        public bool IsDefault { get; set; }
    }

    public class PaymentType : HasId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
