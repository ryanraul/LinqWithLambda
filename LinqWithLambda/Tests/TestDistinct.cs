using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestDistinct : ITest
    {
        public void Test()
        {
            var orders = Database.Database.GetOrders();


            var customerIds = orders.Select(order => order.CustomerId).Distinct();

            foreach (var customerId in customerIds)
            {
                Console.WriteLine(customerId);
            }
        }
    }
}
