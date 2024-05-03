using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class PromotionDetailRequestModel
    {
        //public int Id { get; set; }

        public int PromotionId { get; set; }


        public int ProductCategoryId { get; set; }

    }
}
