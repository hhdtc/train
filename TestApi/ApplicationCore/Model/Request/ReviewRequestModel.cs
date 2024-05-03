using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class ReviewRequestModel
    {
        // int Id { get; set; }
        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public int RatingValue { get; set; }
        public String Comment { get; set; }

        public DateTime ReviewDate { get; set; }

        public int CustomerName { get; set; }

        public int ProductId { get; set; }

        
        public int? OrderId { get; set; }
    }
}
