using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Response
{

    public class ShipperRegionResponseModel
    {
        public int RegionId { get; set; }

        public int ShipperId { get; set; }

    }
}
