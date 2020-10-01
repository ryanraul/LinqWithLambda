using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestUnion : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();
            var orders = Database.Database.GetOrders();

            var firstCustomer = customers.FirstOrDefault();
            var lastCustomer = customers.LastOrDefault();

            var firstCustomerOrders = orders.Where(order => order.CustomerId == firstCustomer.Id);
            var lastCustomerOrders = orders.Where(order => order.CustomerId == lastCustomer.Id);

            var firstAndLastCustomerOrders = firstCustomerOrders.Union(lastCustomerOrders);

            foreach (var order in firstAndLastCustomerOrders)
            {
                Console.WriteLine("Customer Id: " + order.CustomerId + " - Total Value" + order.TotalValue.ToString("c2"));
            }

        }
    }
}
