using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestAll : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();

            var areAllCustomersWithIdGreaterThanZero = customers.All(customer => customer.Id >= 0);

            if (areAllCustomersWithIdGreaterThanZero)
            {
                Console.WriteLine("All customers are with Id equal or greater than 0");
            }
            else 
            { 
                Console.WriteLine("All customers are not with Id equal or greater than 0");
            }

            var areAllCustomersWithAgeGreaterThanTwenty = customers.All(customer => customer.Age > 20);

            if (areAllCustomersWithAgeGreaterThanTwenty)
            {
                Console.WriteLine("All customers are more than 20 years old");
            }
            else
            {
                Console.WriteLine("All customers are not more than 20 years old");
            }
        }
    }
}
