﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class AddressRequestModel
    {
        //public int Id { get; set; }

        public string Street1 { get; set; } = string.Empty;

        public string Street2 { get; set;} = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty; 

        public string ZipCode { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;
    }
}
