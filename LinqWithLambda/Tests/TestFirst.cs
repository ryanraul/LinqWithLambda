using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestFirst : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();

            var firstCustomer = customers.First();
            Console.WriteLine(firstCustomer.Name);

            var firstCustomerAge = customers.First(customer => customer.Age > 30);
            Console.WriteLine(firstCustomerAge.Name + " Age: " + firstCustomerAge.Age);

            try
            {
                var customerWithAgeLessTen = customers.First(customer => customer.Age < 10);
                Console.WriteLine(customerWithAgeLessTen.Name + " Age: " + customerWithAgeLessTen.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no customer with this condition. Details: \n" + ex.ToString());
            }

            //var queryFirstOrDefault = customers.FirstOrDefault();
            var queryFirstOrDefault = customers.FirstOrDefault(customer => customer.Age > 30);
            Console.WriteLine("Using FirstOrDefault: " + queryFirstOrDefault.Name);


            var customerWithAgeLessTenUsingFirstOrDefault = customers.FirstOrDefault(customer => customer.Age < 10);
            
            if(customerWithAgeLessTenUsingFirstOrDefault != null)
            {
                Console.WriteLine("Using FirstOrDefault with age less than ten " + customerWithAgeLessTenUsingFirstOrDefault.Name);

            }
            else
            {
                Console.WriteLine("Using FirstOrDefault and there is no customer using this conidition");
            }

            //var firstAge = customers.Select(customer => customer.Age).FirstOrDefault(age => age <= 10);
            //Console.WriteLine(firstAge);

            var ages = customers.Select(customer => customer.Age);
            var firstAge = ages.FirstOrDefault(age => age <= 10);
            Console.WriteLine(firstAge);
        }

    }
}
