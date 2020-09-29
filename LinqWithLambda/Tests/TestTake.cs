using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestTake : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();


            var firstTenCustomers = customers.Take(10);

            foreach (var customer in firstTenCustomers)
            {
                Console.WriteLine("First Ten Customers: " + customer.Name);
            }

            var takeWhileCustomers = customers.TakeWhile(customer => customer.Age != 40);

            foreach (var customer in takeWhileCustomers)
            {
                Console.WriteLine("Take While: " + customer.Name + " Age: " + customer.Age);
            }
        }
    }
}
