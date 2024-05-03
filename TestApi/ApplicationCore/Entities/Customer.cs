using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    //[Index(nameof(Name), IsUnique = true)]
    public class Customer : HasId
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int Gender { get; set; } = -1;

        public string Phone { get; set; } = string.Empty;

        public string Profile_PIC = string.Empty;


        //0 is customer, 1 is admin
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }




    }

}
