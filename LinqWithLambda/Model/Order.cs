using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWithLambda.Model
{
    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalValue { get; set; }

    }
}
