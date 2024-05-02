using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Address { get; set; }

        public string Password { get; set; }
        //0 is customer, 1 is admin
        public int Type { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public Order Order { get; set; }


    }
}
