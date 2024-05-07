using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.ApplicationCore.Entity
{
    public interface HasId
    {
        public int Id { get; set; }
    }
}
