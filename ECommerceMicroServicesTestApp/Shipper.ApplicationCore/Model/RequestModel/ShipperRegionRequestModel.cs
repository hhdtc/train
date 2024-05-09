using Shipper.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.ApplicationCore.Model.RequestModel
{
    public class ShipperRegionRequestModel
    {
        public int RegionId { get; set; }
        public int ShipperId { get; set; }
    }
}
