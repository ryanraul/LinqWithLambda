using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestSkip : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();
            
            var skipCustomers = customers.Skip(10);
            foreach (var customer in skipCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            var skipWhileCustomers = customers.SkipWhile(customer => customer.Age != 40);
            //var skipWhileCustomers = customers.SkipWhile(customer => customer.Age == 40);

            foreach (var customer in skipCustomers)
            {
                Console.WriteLine("Skip While: " + customer.Name + " Age: " + customer.Age);
            }
        }
    }
}
