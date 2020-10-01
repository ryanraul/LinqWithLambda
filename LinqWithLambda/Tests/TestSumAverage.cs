using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestSumAverage : ITest
    {
        public void Test()
        {
            var orders = Database.Database.GetOrders();

            var sumTotalValues = orders.Sum(order => order.TotalValue);
            var averageTotalValues = orders.Average(order => order.TotalValue);

            Console.WriteLine("Sum Total Values: " + sumTotalValues.ToString("c2"));
            Console.WriteLine("Average Total Values: " + averageTotalValues.ToString("c2"));
            Console.WriteLine("Count Total Orders: " + orders.Count());
            Console.WriteLine("Average Total Values: " + (sumTotalValues / orders.Count()).ToString("c2"));

            var firstCustomerOrders = orders.Where(order => order.CustomerId == 0);
            Console.WriteLine("Firs customer sum total value" + firstCustomerOrders.Sum(order => order.TotalValue).ToString("c2"));
            Console.WriteLine("Firs customer average total value" + firstCustomerOrders.Average(order => order.TotalValue).ToString("c2"));

        }
    }
}
