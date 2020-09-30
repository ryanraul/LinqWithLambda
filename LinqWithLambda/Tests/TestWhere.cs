using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestWhere : ITest
    {
        public void Test()
        {
            var customers = Database.Database.GetCustomers();
            var orders = Database.Database.GetOrders();

            var ageCostumers = customers.Where(customer => customer.Age >= 40 && customer.Age <= 51);
            foreach (var costumer in ageCostumers)
            {
                //Console.WriteLine(costumer.Name + " Age: " + costumer.Age);
            }

            //var firstCustomersOrders = orders.Where(order => (order.CostumerId == 1 && order.TotalValue > 1000) || (order.CostumerId == 2));

            var firstCustomersOrders = orders.Where(order => ValidateOrders(order));

            foreach (var order in firstCustomersOrders)
            {
                Console.WriteLine("Costumer " + order.CostumerId + " purchased: " + order.TotalValue.ToString("c2"));
            }

        }

        private bool ValidateOrders(Model.Order order)
        {
            return (order.CostumerId == 1 && order.TotalValue > 1000) || (order.CostumerId == 2);
        }
    }
}
