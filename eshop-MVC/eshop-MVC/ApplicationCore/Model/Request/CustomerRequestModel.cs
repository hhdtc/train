﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class CustomerRequestModel
    {
        public string Name { get; set; } = string.Empty;
        public  string Address { get; set; } = string.Empty ;

        public string Password { get; set; } = string.Empty;
        //0 is customer, 1 is admin
        public int Type { get; set; } = 0;


    }
}
