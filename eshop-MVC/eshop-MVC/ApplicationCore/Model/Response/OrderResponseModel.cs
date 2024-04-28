﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Response
{
    public class OrderResponseModel

    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int ShipperId { get; set; }

        public int CustomerId { get; set; }
    }
}
