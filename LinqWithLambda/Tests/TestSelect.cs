using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestSelect : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();

            var firstQueryCustomers = from customer in customers
                                      //select customer.Name;
                                      //select new {customer.Id, customer.Name};
                                      select new { customer.Id,NameCustomer = customer.Name};
            /*
            foreach (var costumer in firstQueryCustomers)
            {
                Console.WriteLine(costumer.NameCustomer);
            }
            */

            var secondaryQueryWithLambda = customers
                //.Select( customer => customer.Name);
                //.Select( customer => new { customer.Id ,customer.Name });
                .Select( customer => new { Description = "Costumer Name: " + customer.Name + " Age: " + customer.Age });


            foreach (var customer in secondaryQueryWithLambda)
            {
                Console.WriteLine(customer.Description);
            }
        }
    }
}
