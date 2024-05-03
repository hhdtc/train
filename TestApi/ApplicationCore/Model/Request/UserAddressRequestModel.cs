using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class UserAddressRequestModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public int AddressId { get; set; }


        public bool IsDefaultAddress { get; set; }


    }
}
