using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.ApplicationCore.Entity
{
    public class Shippers : HasId
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //[Column(TypeName = "decimal(18,4)")]
        //public decimal Price { get; set; }

        public int EmailId { get; set; } = 0;

        public string Phone { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

    }
}
