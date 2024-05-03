using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class ShoppingCart : HasId
    {
        public int Id { get; set; }


        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string CustomerName { get; set; }






    }
}
