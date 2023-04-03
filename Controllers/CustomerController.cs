using SysproWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SysproWebApi.Controllers
{
    [Route("api/customers")]

    public class CustomerController : ApiController
    {
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            var customers = new Customers();
            return customers.GetCustomers();
        }

        [HttpPost]
        public string CreateCustomer()
        {
            var customers = new Customers();
            return "created";
        }

        [HttpPut]
        public string Update(int id)

        {
            return "updated";
        }
    }
}