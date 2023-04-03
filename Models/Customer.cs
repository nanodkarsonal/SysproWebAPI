

using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace SysproWebApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Customers

    {
        List<Customer> customers = new List<Customer>();
        public List<Customer> GetCustomers()
        {
            customers.Add(new Customer { Id = 1, Name = "Sonal" });
            customers.Add(new Customer { Id = 2, Name = "Raj" });
            customers.Add(new Customer { Id = 3, Name = "Trevor" });

            return customers;
        }

        
    }
}