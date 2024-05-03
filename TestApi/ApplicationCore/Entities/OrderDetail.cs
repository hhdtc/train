using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class OrderDetail : HasId
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public decimal Qty { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }
    }
}
