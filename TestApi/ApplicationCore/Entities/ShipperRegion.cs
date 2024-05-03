using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{

    [PrimaryKey(nameof(RegionId), nameof(ShipperId))]
    public class ShipperRegion
    {
        public int RegionId { get; set; }
        public Region Region { get; set; }

        public int ShipperId { get; set; }

        public Shipper Shipper { get; set; }
    }
}
