using Order.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.ApplicationCore.Model.ResponseModel
{
    public class OrderResponseModel
    {
        public int Id { get; set; }
        //public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }


        public int CustomerId { get; set; }

        //public Customer Customer { get; set; }

        public string CustomerName { get; set; }

        public int? PaymentMethodId { get; set; }

        //public PaymentMethod PaymentMethod { get; set; }

        public string PaymentName { get; set; }

        public string ShippingAddress { get; set; }

        public int ShippingMethod { get; set; }

        public Decimal BillAmount { get; set; }

        public int OrderStatus { get; set; }





        //public ICollection<Review> reviews { get; set; }

    }
}
