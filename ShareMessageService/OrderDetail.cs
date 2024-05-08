using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareMessageService
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int ProductName { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}
