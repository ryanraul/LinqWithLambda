using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestOrderBy : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();
            var orders = Database.Database.GetOrders();

            var customerOrders = customers.Join(
                orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, order) => new
                    {
                        CustomerId = customer.Id,
                        Name = customer.Name,
                        Age = customer.Age,
                        TotalValue = order.TotalValue,
                        CreatedDate = order.CreatedDate
                    }
                );

            foreach (var customerOrder in customerOrders.OrderBy(order => order.TotalValue))
            {
                //Console.WriteLine(customerOrder.Name + " purchased " + customerOrder.TotalValue.ToString("c2"));
            }

            foreach (var customerOrder in customerOrders.OrderBy(order => order.Name).ThenBy(order => order.TotalValue))
            {
                //Console.WriteLine(customerOrder.Name + " purchased " + customerOrder.TotalValue.ToString("c2"));
            }


            foreach (var customerOrder in customerOrders.OrderByDescending(order => order.TotalValue))
            {
                //Console.WriteLine(customerOrder.Name + " purchased " + customerOrder.TotalValue.ToString("c2"));
            }

            foreach (var customerOrder in customerOrders.OrderBy(order => order.Name).ThenByDescending(order => order.TotalValue))
            {
                Console.WriteLine(customerOrder.Name + " purchased " + customerOrder.TotalValue.ToString("c2"));
            }
        }
    }
}
