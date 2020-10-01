using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestGroupBy : ITest
    {
        public void Test()
        {
            var orders = Database.Database.GetOrders();

            var totalOrders = orders.GroupBy(order => order.CustomerId)
                .Select(order => new
                    {
                        CustomerId = order.Key,
                        TotalValue = order.Sum(x => x.TotalValue),
                        AverageValue = order.Average(x => x.TotalValue),
                        CountOrders = order.Count()
                    }
                );

            foreach (var totalOrder in totalOrders)
            {
                Console.WriteLine("Customer " + totalOrder.CustomerId 
                    + " - Total Value: " + totalOrder.TotalValue.ToString("c2") 
                    + " - Average: " + totalOrder.AverageValue.ToString("c2")
                    + " - Count Orders " + totalOrder.CountOrders);
            }
        }
    }
}
