﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class VariationValue
    {
        public int Id { get; set; }
        public int VariationId { get; set; }
        public CategoryVariation CategoryVariation { get; set; }

        public int value { get; set; }
    }
}
