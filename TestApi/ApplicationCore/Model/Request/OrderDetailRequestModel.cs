﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class OrderDetailRequestModel
    {
        //public int Id { get; set; }

        public int OrderId { get; set; }


        public int ProductId { get; set; }


        public string ProductName { get; set; } = string.Empty;

        public decimal Qty { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }
    }
}
