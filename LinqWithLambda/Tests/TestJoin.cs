using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestJoin : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();
            var orders = Database.Database.GetOrders();

            //Commun method
            /*
            foreach (var customer in customers)
            {
                foreach (var order in orders)
                {
                    if (customer.Id == order.CostumerId)
                    {
                        //This order is from this customer

                    }
                }
            }
            */

            //Join with repeat customers
            /*
            var customerOrders = customers.Join(
                    orders,
                    customer => customer.Id,
                    order => order.CostumerId,
                    //( customer, order) => new {Customer = customer, Order = order}
                    (customer, order) => new {Name = customer.Name, TotalValue = order.TotalValue, CreatedDate = order.CreatedDate}
                );

            foreach (var customerOrder in customerOrders)
            {
                /*
                Console.WriteLine("The customer " + customerOrder.Customer.Name 
                    + " purchased " + customerOrder.Order.TotalValue.ToString("c2") 
                    + " in " + customerOrder.Order.CreatedDate.ToString("dd/MM/yyyy"));
                
                Console.WriteLine("The customer " + customerOrder.Name
                    + " purchased " + customerOrder.TotalValue.ToString("c2")
                    + " in " + customerOrder.CreatedDate.ToString("dd/MM/yyyy"));
            }
            */

            var customerOrders = customers.GroupJoin(
                    orders,
                    customer => customer.Id,
                    order => order.CustomerId,
                    ( customer, allOrders ) => new {Customer = customer, AllOrders = allOrders}
                );

            foreach (var customerOrder in customerOrders)
            {
                Console.WriteLine("The customer " + customerOrder.Customer.Name + " purchased ");

                foreach (var order in customerOrder.AllOrders)
                {
                    Console.WriteLine("Total Value: " + order.TotalValue.ToString("c2") + " in " + order.CreatedDate.ToString("dd/MM/yyyy"));
                }

            }
        }
    }
}
