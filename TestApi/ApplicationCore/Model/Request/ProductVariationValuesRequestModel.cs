﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Model.Request
{
    public class ProductVariationValuesRequestModel
    {

        public int ProductId { get; set; }

        public int VariationValueId { get; set; }

    }
}
