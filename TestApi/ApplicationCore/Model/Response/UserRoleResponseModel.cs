using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Response
{
    public class UserRoleResponseModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public int RoleId { get; set; }

        public RoleResponseModel Role { get; set; }
    }
}
