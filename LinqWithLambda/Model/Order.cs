using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWithLambda.Model
{
    class Order
    {
        public int Id { get; set; }
        public int CostumerId { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal TotalValue { get; set; }

    }
}
