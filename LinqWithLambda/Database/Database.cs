using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWithLambda.Database
{
    static class Database
    {
        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            for (int index = 0; index <= 50; index++)
            {
                var customer = new Customer();
                customer.Id = index;
                customer.Name = $"Customer {index}";
                customer.Age = 18 + index;
                customers.Add(customer);
            }

            return customers;
        }

        public static List<Order> GetOrders()
        {
            var customerId = 0;
            var orders = new List<Order>();

            for (int index = 0; index < 1000; index++)
            {

                var order = new Order();
                if (customerId > 50)
                    customerId = 0;

                order.Id = index;
                order.CostumerId = customerId;
                order.CreateDate = DateTime.Now;
                order.TotalValue = 10 * index;

                orders.Add(order);
                customerId++;
            }
            return orders;
        }
    }
}
