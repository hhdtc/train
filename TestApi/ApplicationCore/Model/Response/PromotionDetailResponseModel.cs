using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Response
{
    public class PromotionDetailResponseModel
    {
        public int Id { get; set; }

        public int PromotionId { get; set; }

        public Promotion Promotion { get; set; }

        public int ProductCategoryId { get; set; }

        public Category Category { get; set; }
    }
}
