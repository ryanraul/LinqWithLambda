using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestCountMaxMin : ITest
    {
        public void Test()
        {
            var orders = Database.Database.GetOrders();

            var orderCount = orders.Count();
            Console.WriteLine("Orders count: " + orderCount);

            var maxTotalValue = orders.Max(order => order.TotalValue);
            Console.WriteLine("Orders max Total value: " + maxTotalValue.ToString("c2"));

            var minTotalValue = orders.Min(order=> order.TotalValue);
            Console.WriteLine("Orders min Total value: " + minTotalValue.ToString("c2"));

            var firstCustomerOrders = orders.Where(order => order.CustomerId == 0);
            Console.WriteLine("First customer orders count: " + firstCustomerOrders.Count());
            Console.WriteLine("First customer order max total value: " + firstCustomerOrders.Max(order => order.TotalValue).ToString("c2"));
            Console.WriteLine("First customer order min total value: " + firstCustomerOrders.Min(order => order.TotalValue).ToString("c2"));
        }
    }
}
