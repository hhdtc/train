using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class ShoppingCartItem : HasId
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public ShoppingCart ShoppingCart;

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public String ProductName { get; set; }

        public Decimal Qty { get; set; }

        public Decimal Price { get; set; }
    }
}
