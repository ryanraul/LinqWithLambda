using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestContains : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();

            var customerIds = customers.Select(customer => customer.Id);

            if (customerIds.Contains(100))
            {
                Console.WriteLine("There is a customer with id = 1.");
            }
            else
            {
                Console.WriteLine("There is not a customer with id = 1.");
            }


            var customerNames = customers.Select(customer => customer.Name);

            if(customerNames.Contains("Customer 0"))
            {
                Console.WriteLine("There is a customer with name like Customer 0");
            }
            else
            {
                Console.WriteLine("There is not a customer with name like Customer 0");
            }
        }
    }
}
