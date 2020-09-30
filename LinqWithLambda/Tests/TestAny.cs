using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestAny : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();
            var orders = Database.Database.GetOrders();

            var bigOrders = orders.Where(order => order.TotalValue > 500000);

            if (bigOrders.Any())
            {
                Console.WriteLine("We have big orders.");
            }
            else
            {
                Console.WriteLine("We don't big orders.");
            }

            var hasBigOrders = orders.Any(order => order.TotalValue > 500000);

            if (hasBigOrders)
            {
                Console.WriteLine("We have big orders. (New way)");
            }
            else
            {
                Console.WriteLine("We don't big orders. (New way)");
            }

            var oldCustomersOrders = orders.Where(order => customers.Any(customer => customer.Id == order.CustomerId && customer.Age > 50));

            foreach (var order in oldCustomersOrders)
            {
                Console.WriteLine("Costumer ID: " + order.CustomerId + " - Purchased: " + order.TotalValue.ToString("c2"));
            }
        }
    }
}
