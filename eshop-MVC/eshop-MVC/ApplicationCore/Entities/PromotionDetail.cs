using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class PromotionDetail
    {
        public int Id { get; set; }

        public int PromotionId { get; set; }

        public Promotion Promotion { get; set; }

        public int ProductCategoryId {get; set;}
        
        public Category Category { get; set;}

        
    }
}
