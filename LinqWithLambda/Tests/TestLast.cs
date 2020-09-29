using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestLast : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();

            var lastCustomer = customers.Last();
            Console.WriteLine(lastCustomer.Name);

            try
            {
                var errorCostumer = customers.Last(customer => customer.Id < 0);
            }
            catch
            {

            }

            var customerWithLastOrDefault = customers.LastOrDefault(customer => customer.Id < 0);
            if(customerWithLastOrDefault == null)
            {
                Console.WriteLine("There is no customer with this condition");
            }

            var customerWithAge = customers.LastOrDefault(customer => customer.Age <= 40);
            Console.WriteLine(customerWithAge.Name);

        }
    }
}
