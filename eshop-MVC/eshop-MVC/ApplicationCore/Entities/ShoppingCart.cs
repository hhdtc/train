﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }





    }
}
