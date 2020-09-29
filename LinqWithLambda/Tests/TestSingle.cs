using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestSingle : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();

            //var customerWithAge = customers.Single(customer => customer.Age == 19);

            //Try - Catch
            //var customerWithAge = customers.Single(customer => customer.Age == 10);
            var customerWithAge = customers.SingleOrDefault(customer => customer.Age == 10);
            if (customerWithAge != null)
            {
                Console.WriteLine(customerWithAge.Id + " - " + customerWithAge.Name + " Age: " + customerWithAge.Age);
            }
            else
            {
                Console.WriteLine("There is no customer with this condition");
            }
            
            //var customerWithFirst = customers.First(customer => customer.SecondAge == 19);
            //var customerWithSingle = customers.Single(customer => customer.SecondAge == 19);

            //var customerAnotherDifference = customers.FirstOrDefault(customer => customer.Age > 20);
            //Console.WriteLine("This is the selected customer: " + customerAnotherDifference.Name);

            var customerAnotherDifference = customers.SingleOrDefault(customer => customer.Age > 20);
            Console.WriteLine("This is the selected customer: " + customerAnotherDifference.Name);


        }
    }
}
