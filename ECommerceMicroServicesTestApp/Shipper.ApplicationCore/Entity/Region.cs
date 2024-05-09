using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.ApplicationCore.Entity
{
    public class Region : HasId
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
