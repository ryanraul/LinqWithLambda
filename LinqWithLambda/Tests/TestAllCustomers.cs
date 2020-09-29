using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestAllCustomers : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
